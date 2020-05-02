using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Data.SqlClient;
using System.Collections;

namespace My_Lyrics
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public static string Song_Artist = string.Empty;
        public static string Song_Title = string.Empty;
        public static string Song_Album = string.Empty;
        public static Nullable<uint> Song_History = 0;
        public static string Song_Lenght = string.Empty;
        public static Nullable<float> Song_Size = 0;
        public static string Song_Lyrics = string.Empty;
        public static string Song_Location = string.Empty;
        public static bool Have_Lyrics = false;
        public static bool Have_Artist = false;
        public static TagLib.File file;


        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape) this.Close();
        }
        [Obsolete]
        private void Browse_Music_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openfile = new System.Windows.Forms.OpenFileDialog();
            openfile.Title = "Browse media file";
            openfile.Filter = "MP3 Files | *.mp3";
            if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Window1.file = TagLib.Audible.File.Create(openfile.FileName);
                    Window1.Song_Artist = (file.Tag.Artists[0] == null) ? "Nothing" : file.Tag.Artists[0].ToString();
                    Window1.Song_Album = (file.Tag.Album.ToString() == null) ? "Nothing" : file.Tag.Album.ToString();
                    Window1.Song_History = (file.Tag.Year.ToString() == null) ? 0 : file.Tag.Year;
                    Window1.Song_Lenght = (file.Properties.Duration.ToString() == null) ? "Nothing" : file.Properties.Duration.ToString();
                    Window1.Song_Title = (file.Tag.Title == null) ? "Nothing" : file.Tag.Title;
                    Window1.Song_Location = openfile.FileName;
                    Window1.Song_Size = ((new FileInfo(openfile.FileName).Length) / 1000000);
                    Have_Lyrics = (file.Tag.Lyrics == null) ? false : true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}\nThere is empty space!\nBut we do it ;)", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }

        public void ThereIsArtist_Func(string connectionString, string Lyrics) //In that function, we put data on info_table only...
        {
            ArrayList array = new ArrayList();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataReader reader = new SqlCommand("Select Artist from Artist_Table", connection).ExecuteReader();
            SqlCommand command = new SqlCommand();
            while (reader.Read())
            {
                array.Add(reader.GetString(0));
            }
            connection.Close();
            Have_Artist = (array.Contains(Window1.Song_Artist)) ? true : false;
            if (Have_Artist)
            {
                MessageBox.Show(Lyrics);
                command.Connection = connection;
                command.CommandText = "Insert into Info_Table(Artist,Title,Album,History,Lenght,Size,Lyrics,Location) values(@ar,@ti,@al,@hi,@le,@si,@ly,@lo)";
                command.Parameters.AddWithValue("@ar", Window1.Song_Artist);
                command.Parameters.AddWithValue("@ti", Window1.Song_Title);
                command.Parameters.AddWithValue("@al", Window1.Song_Album);
                command.Parameters.AddWithValue("@hi", (int)Window1.Song_History);
                command.Parameters.AddWithValue("@si", Window1.Song_Size);
                command.Parameters.AddWithValue("@ly", Lyrics);
                command.Parameters.AddWithValue("@le", Window1.Song_Lenght);
                command.Parameters.AddWithValue("@lo", Window1.Song_Location);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("New track and album added!", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show(Lyrics);
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Insert into Artist_Table(Artist) values(@a)";
                command.Parameters.AddWithValue("@a", Window1.Song_Artist);
                command.ExecuteNonQuery();
                connection.Close();
                command.CommandText = "Insert into Info_Table(Artist,Title,Album,History,Lenght,Size,Lyrics,Location) values(@ar,@ti,@al,@hi,@le,@si,@ly,@lo)";
                command.Parameters.AddWithValue("@ar", Window1.Song_Artist);
                command.Parameters.AddWithValue("@ti", Window1.Song_Title);
                command.Parameters.AddWithValue("@al", Window1.Song_Album);
                command.Parameters.AddWithValue("@hi", (int)Window1.Song_History);
                command.Parameters.AddWithValue("@si", Window1.Song_Size);
                command.Parameters.AddWithValue("@ly", Lyrics);
                command.Parameters.AddWithValue("@le", Window1.Song_Lenght);
                command.Parameters.AddWithValue("@lo", Window1.Song_Location);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("New artist added!", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {
            new Window1().ThereIsArtist_Func("Data Source=.;Initial Catalog=Lyrics_DB;Integrated Security=True", Lyrics_TextBox.Text);
        }

        private void Lyrics_TextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            Lenght_TextBlock.Text = Lyrics_TextBox.Text.Length.ToString();
        }

    }
}
