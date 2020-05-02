using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class Insert_Book_Form : Form
    {
        public Insert_Book_Form()
        {
            InitializeComponent();
        }
        public StringCollection MyList;
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
                
            
        }

        private void Insert_Book_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void GroupBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Insert_Book_Form_Load(object sender, EventArgs e)
        {
            MyList = new StringCollection();
            for (int i = 0; i <= 9; ++i)
            {
                MyList.Add(i.ToString());
            }
        }

        private void TextBox1_MouseLeave(object sender, EventArgs e)
        {
            
            if (!MyList.Contains(textBox1.Text.Split(' ')[0]))
            {
                MessageBox.Show(textBox1.Text.Split(' ')[0]);
                MessageBox.Show("Only number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); textBox1.Text = "0";
            }
        }
    }
}
