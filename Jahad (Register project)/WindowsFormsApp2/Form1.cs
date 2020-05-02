using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox1.Text == "Enter your name" || textBox2.Text == "Enter your lastname" || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Enter all inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You registered.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox1.SelectionLength = 0;
            textBox1.SelectionStart = 0;
            textBox2.SelectionLength = 0;
            textBox2.SelectionStart = 0;

            textBox1.Text = "Enter your name";
            textBox2.Text = "Enter your lastname";

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && textBox2.Text == "Enter your lastname")
            {
                textBox2.Text = string.Empty;
                textBox2.ForeColor = Color.Black;
                textBox2.SelectionLength = 0;
                textBox2.SelectionStart = 0;
            }

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && textBox1.Text == "Enter your name")
            {
                textBox1.Text = string.Empty;
                textBox1.ForeColor = Color.Black;
                textBox1.SelectionLength = 0;
                textBox1.SelectionStart = 0;
                
            }
        }
    }
}
