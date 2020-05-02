using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization;
using System.IO;

namespace Mesh__Form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            lblPath.Text = string.Empty;
            chart1.Series[0].LegendText = string.Empty;
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            listBox1.HorizontalScrollbar = true;
            chart1.Series[0].LegendText = "Z001";
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 23500;

        }

        public async void Data_Reader(string Location)
        {
            List<string> MyList = new List<string>();
            StreamReader reader = new StreamReader(Location);
            //string Read_Data = await reader.ReadToEndAsync();
            string Read_Data = string.Empty;
            for (int i = 0; i < 4097; i++)
            {
                Read_Data = await reader.ReadLineAsync();
                //foreach (string s2 in Read_Data.Split(' '))
                //{
                    //if (s2 != string.Empty)
                    //{
                        //MyList.Add(Read_Data);
                    //}
                    //listBox1.Items.Add(MyList[21]);
                    //lblCounter.Text = listBox1.Items.Count.ToString();
                    //MessageBox.Show(MyList.Count.ToString());
                //}
                listBox1.Items.Add(Read_Data);
                lblCounter.Text = listBox1.Items.Count.ToString();
                MyList.Clear();
            }
                
            //for (int i = 0; i <= 10000; i++) Perfect
            //{
            //    Read_Data = await reader.ReadLineAsync();
            //    if (Read_Data.Split(' ')[3].Equals(""))
            //    {
            //        //MyList.Add(Read_Data.Split(' ')[4]/*.Split('-')[1]*/);
            //        listBox1.Items.Add(Read_Data.Split(' ')[4]/*.Split('-')[1]*/);
            //    }
            //    else
            //    {
            //        listBox1.Items.Add(Read_Data.Split(' ')[3]/*.Split('-')[1]*/);
            //    }
            //    lblCounter.Text = i.ToString();
            //}
            //////for (int i = 0; i < listBox1.Items.Count; i++)
            //////{
            //////    if (listBox1.Items[i].ToString() == "")
            //////    {
            //////        listBox1.Items.RemoveAt(i);
            //////    }
            //////}
            button2.Enabled = true;
            //foreach (string PerEnter in Read_Data.Split('\n'))
            //{
            //    if (PerEnter.Split(' ')[3].Equals(""))
            //    {
            //        MyList.Add(PerEnter.Split(' ')[4]/*.Split('-')[1]*/);
            //        listBox1.Items.Add(PerEnter.Split(' ')[4]/*.Split('-')[1]*/);
            //    }
            //    else
            //    {
            //        MyList.Add(PerEnter.Split(' ')[3]/*.Split('-')[1]*/);
            //        listBox1.Items.Add(PerEnter.Split(' ')[3]/*.Split('-')[1]*/);
            //    }
                
            //}
            reader.Close();
        }

        public async void Draw_Chart()
        {
            double Counter = 5.7;
            await Task.Run(() => 
            {
                for (int i = 0; i < 4097; i++)
                {
                    chart1.Invoke(new MethodInvoker(() =>
                    {
                        chart1.Series[0].Points.AddXY(Counter, listBox1.Items[i]);
                    }));
                    Counter += 5.7;
                }
            });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open file";
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblPath.Text = open.FileName;
                Data_Reader(open.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                    Draw_Chart();
             
        }
    }
}
