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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections;

namespace My_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    class Loading_Drives
    {
        public string DrivesName { get; set; }
        public string ImageSource { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
    }


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public ArrayList Former_Everything = new ArrayList();

        public Dictionary<int, string> MyDictionary;

        public int Everything_Intialize = 0;
        private void Exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Minimize_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var Drives = DriveInfo.GetDrives();
            MyDictionary = new Dictionary<int, string>();
            foreach (var Drive in Drives)
            {
                if (Drive.DriveType == DriveType.Fixed)
                {
                    Drivers_List.Items.Add(new Loading_Drives() { DrivesName = Drive.Name, ImageSource = Directory.GetCurrentDirectory() + "\\img\\" + "hard-disk-64.ico" });
                    MyDictionary.Add(Drivers_List.Items.Count, Drive.Name); //For access to TextBlock Text in selecting items in Drivers_List. With that algorithm, we can get TextBlock Text for access to directory.
                    //MessageBox.Show(Drivers_List.Items.Count.ToString());
                }
                else if (Drive.DriveType == DriveType.CDRom)
                {
                    Drivers_List.Items.Add(new Loading_Drives() { DrivesName = Drive.Name, ImageSource = Directory.GetCurrentDirectory() + "\\img\\" + "cd-64.ico" });
                    MyDictionary.Add(Drivers_List.Items.Count, Drive.Name);
                    //MessageBox.Show(Drivers_List.Items.Count.ToString());
                }
                else
                {
                    Drivers_List.Items.Add(new Loading_Drives() { DrivesName = Drive.Name, ImageSource = Directory.GetCurrentDirectory() + "\\img\\" + "usb-2-64.ico" });
                }
            }

        }

        private void Drivers_List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //How remove ListView former items?
            //For that question, i found 1 solution...
            //I defined one variable and named: Everything_Itialize that keep last number of Data_List Items count. Then by for loop (bottom) I try to
            //remove element 0 in Data_List until (i) value reach to Everything_Intialize. Former_Everything is an array that keep all files and directories
            //that we need to remove them before add new files and directories (after clicking on new partition).
            try
            {
                var AllDirectories = Directory.GetDirectories(MyDictionary[Drivers_List.SelectedIndex + 1]); //I used Dictionary to access Items value (partitions name).
                var AllFiles = Directory.GetFiles(MyDictionary[Drivers_List.SelectedIndex + 1]);                
                
                FileInfo file;
                DirectoryInfo directory;


                if (Everything_Intialize > 0)
                {
                    for (int i = 0; i < Everything_Intialize; ++i)
                    {
                        Data_List.Items.RemoveAt(0);
                    }
                }
                Everything_Intialize = 0;
                
                foreach (string _Directory in AllDirectories)
                {
                    directory = new DirectoryInfo(_Directory);
                    Data_List.Items.Add(new Loading_Drives() { ImageSource = Directory.GetCurrentDirectory() + "\\img\\folder-6-128.ico", FileName = directory.Name });
                    Former_Everything.Add(directory.Name);
                }
                foreach (string _File in AllFiles)
                {
                    file = new FileInfo(_File);
                    if (file.Extension == ".mp3")
                    {
                        Data_List.Items.Add(new Loading_Drives() { ImageSource = Directory.GetCurrentDirectory() + "\\img\\dj-128.ico", FileName = file.Name, FileExtension = file.Extension });
                    }
                    else if (file.Extension == ".jpg" || file.Extension == ".png" || file.Extension == ".ico" || file.Extension == ".jpeg")
                    {
                        Data_List.Items.Add(new Loading_Drives() { ImageSource = Directory.GetCurrentDirectory() + "\\img\\camera-128.ico", FileName = file.Name, FileExtension = file.Extension });
                    }
                    else if (file.Extension == ".exe")
                    {
                        Data_List.Items.Add(new Loading_Drives() { ImageSource = Directory.GetCurrentDirectory() + "\\img\\computer-128.ico", FileName = file.Name, FileExtension = file.Extension });
                    }
                    else if (file.Extension == ".apk" || file.Extension == ".ipa" || file.Extension == ".xap" || file.Extension == ".cod" || file.Extension == ".alx")
                    {
                        Data_List.Items.Add(new Loading_Drives() { ImageSource = Directory.GetCurrentDirectory() + "\\img\\phone-128.ico", FileName = file.Name, FileExtension = file.Extension });
                    }
                    else
                    {
                        Data_List.Items.Add(new Loading_Drives() { ImageSource = Directory.GetCurrentDirectory() + "\\img\\document-128.ico", FileName = file.Name, FileExtension = file.Extension });
                    }
                    Former_Everything.Add(file.Name);
                }

                Everything_Intialize = Former_Everything.Count;
                Former_Everything.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        
    }
}