using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Library_Project
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        

        private void Main_Form_Load(object sender, EventArgs e)
        {
            new Loading_Form().Close();
            timer1.Enabled = true;
            timer1.Start();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            //dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            label1.Text = string.Empty;
            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { }
        }

        private void Main_Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //For maximizing and changing to normal window.
            {
                if (e.Clicks == 2 && this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else if (e.Clicks == 2 && this.WindowState == FormWindowState.Maximized) 
                {
                    this.WindowState = FormWindowState.Normal;
                }
            }
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.UtcNow.Year.ToString() + "-" + DateTime.UtcNow.Month.ToString() + "-" + DateTime.UtcNow.DayOfWeek.ToString(); //Get day, month and year.
            label2.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(); //Get hour, minute and second.
        }

        private void Main_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else { }
            }
        }

        private void Main_Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else { }
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else { }
            }

        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Form about_Form = new About_Form();
            about_Form.ShowDialog();

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            
        }

        private void InsertNewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insert_Member_Form insert_Member_Form = new Insert_Member_Form();
            insert_Member_Form.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help_Form help_Form = new Help_Form();
            help_Form.ShowDialog();
        }

        private void InsertNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insert_Book_Form insert_Book_Form = new Insert_Book_Form();
            insert_Book_Form.ShowDialog();
        }
    }
}
