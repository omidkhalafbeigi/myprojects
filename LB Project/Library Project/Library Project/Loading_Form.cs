using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;

namespace Library_Project
{
    public partial class Loading_Form : Form
    {
        public Loading_Form()
        {
            InitializeComponent();
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.StartPosition = FormStartPosition.CenterScreen;
            timer1.Enabled = true;
            timer1.Start();
            
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.01;
            }
            else if (this.Opacity == 1)
            {
                Thread.Sleep(1000);
                timer2.Enabled = true;
                timer2.Start();
            }

        }
        
        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            this.Opacity -= 0.01;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                Main_Form mf = new Main_Form();
                mf.ShowDialog();
                this.Close();
            }
        }

        private void Loading_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
