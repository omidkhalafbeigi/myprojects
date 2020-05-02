using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Dock = DockStyle.Fill;
            chart1.Series[0].LegendText = "Sinus(X)";
            chart1.Series[1].LegendText = "Cosinus(X)";
            chart1.Series[1].ChartType = SeriesChartType.Spline;
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            for (double i = 0; i <= 2 * Math.PI; i += 0.001)
            {
                chart1.Series[0].Points.AddXY(i, Math.Sin(i));
                chart1.Series[1].Points.AddXY(i, Math.Cos(i));
            }

        }
    }
}
