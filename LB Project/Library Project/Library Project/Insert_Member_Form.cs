using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class Insert_Member_Form : Form
    {
        public Insert_Member_Form()
        {
            InitializeComponent();
        }

        private void Insert_Member_Form_KeyDown(object sender, KeyEventArgs e)
        {
            Main_Form main_Form = new Main_Form();
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
