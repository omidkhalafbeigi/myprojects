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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.IO;
using System.Windows.Shapes;
//---------------------------
using System.Timers;
using NAudio;
//using TagLib;
using TagLib.Audible;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Media;
using System.ComponentModel;
using File = TagLib.Audible.File;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace My_Lyrics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///

        
    class Sql_Working
    {

        
        public void Read_Primary_Data(string Connection_String, ListView list) //For musics list
        {
            SqlConnection connection = new SqlConnection(Connection_String);
            connection.Open();
            SqlDataReader reader = new SqlCommand("Select * from dbo.Info_Table", connection).ExecuteReader();
            while (reader.Read())
            {
                list.Items.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString());
            }
            connection.Close();
        }
        public void Read_Full_Data(string Connection_String,ref string Location , string Artist_Name, string Title_Name, TextBlock Artist, TextBlock Title, TextBlock Album, TextBlock History, TextBlock Lenght, TextBlock Size, TextBox Lyrics) //For TextBlocks (like artist, title and etc.)
        {
            SqlConnection connection = new SqlConnection(Connection_String);
            connection.Open();
            SqlDataReader reader = new SqlCommand("Select * from dbo.Info_Table", connection).ExecuteReader();
            while (reader.Read())
            {
                if (Artist_Name == reader.GetValue(0).ToString() && Title_Name == reader.GetValue(1).ToString())
                {
                    Artist.Text = reader.GetValue(0).ToString();
                    Title.Text = reader.GetValue(1).ToString();
                    Album.Text = reader.GetValue(2).ToString();
                    History.Text = reader.GetValue(3).ToString();
                    Lenght.Text = reader.GetValue(4).ToString();
                    Size.Text = reader.GetValue(5).ToString() + " MB";
                    Lyrics.Text = reader.GetValue(6).ToString();
                    Location = reader.GetValue(7).ToString();
                    break;
                }
                
            }
            connection.Close();
        }
    }

    public partial class MainWindow : Window
    {
        [DllImport("user32.dll")]
        public static extern int GetWindowRect(IntPtr HWND, ref Rect rect);

        public struct Rect
        {
            public int Left { get; set; }
            public int Right { get; set; }
            public int Top { get; set; }
            public int Bottom { get; set; }
        }
        public struct Pos
        {
            public int X { get; set; } public int Y { get; set; }
        }

        [DllImport("user32.dll")]
        public static extern int GetCursorPos(out Pos pos);

        [DllImport("user32.dll")]
        public static extern int SetWindowPos(IntPtr hwnd, IntPtr hwndafter, int x, int y, int height, int width, uint a);


        private bool Hold = false;
        public string Connection_String = "Data Source=.;Initial Catalog=Lyrics_DB;Integrated Security=True";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Sql_Working working = new Sql_Working();
            working.Read_Primary_Data(Connection_String, Musics_List);
        }

               

        private void Exit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();            
        }

        private void Minimize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        public NAudio.Wave.WaveOut wave = new NAudio.Wave.WaveOut();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //All_Values values = new All_Values();
            if (Musics_List.SelectedIndex == -1)
            {
                MessageBox.Show("Choose music!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                string Location = string.Empty;
                Sql_Working working = new Sql_Working();
                
                    working.Read_Full_Data(Connection_String, ref Location, Musics_List.SelectedItem.ToString().Split('-')[0], Musics_List.SelectedItem.ToString().Split('-')[1], Artist_Text, Title_Text, Album_Text, Year_Text, Lenght_Text, Size_Text, Lyrics_Text);
                    wave.Init(new NAudio.Wave.Mp3FileReader(Location));
                    wave.Play();
                    State_Text.Text = "Playing...";
                    State_Text.Foreground = Brushes.Green;
                
                
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (State_Text.Text == "None")
            {
                MessageBox.Show("Music isn't playing!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                wave.Stop();
                State_Text.Text = "Stopped...";
                State_Text.Foreground = Brushes.Red;
            }
            
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
                Window1 music = new Window1();
                music.ShowDialog();
            }
            
            
        }

        private void Scroll_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.S)
            {
                Lyrics_Text.LineDown();
            }
            else if (e.Key == Key.W)
            {
                Lyrics_Text.LineUp();
            }
            else if (e.Key == Key.A)
            {
                Lyrics_Text.ScrollToHome();
            }
            else if (e.Key == Key.D)
            {
                Lyrics_Text.ScrollToEnd();
            }
        }

        private void Exit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
            else if (e.Key == Key.R)
            {
                //Musics_List.Items.RemoveAt(0);
                for (int i = 0; i <= Musics_List.Items.Count + 4; i++)
                {
                    Musics_List.Items.RemoveAt(0);
                }
                new Sql_Working().Read_Primary_Data(Connection_String, Musics_List);
            }
        }
        public Timer timer = new Timer(1);
        public Process process;
        public string processName;
        public int Cursor_X;
        public int Cursor_Y;
        public Pos pos;
        public IntPtr HWND;
        public int Width;
        public int Height;
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Hold = (Hold == false) ? true : false;
            }
            //MessageBox.Show(Hold.ToString());
            if (Hold == true)
            {
                Width = (int)myWindow.Width;
                Height = (int)myWindow.Height;
                MessageBox.Show($"{Height} {Width}");
                process = Process.GetProcessesByName("My Lyrics")[0];
                HWND = process.MainWindowHandle;
                timer.Enabled = true;
                timer.Start();
                timer.Elapsed += Timer_Elapsed;
            }
            else
            {
                timer.Stop();
                timer.Enabled = false;
            }

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            
            if (Hold == true)
            {
                GetCursorPos(out pos);
                SetWindowPos(HWND, IntPtr.Zero, 200, 400, 250, 473, 0);
            }
            else
            {

            }
        }
    }
}
