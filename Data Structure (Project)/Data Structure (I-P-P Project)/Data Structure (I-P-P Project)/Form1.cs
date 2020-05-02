using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structure__I_P_P_Project_
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Methods.DropDownStyle = ComboBoxStyle.DropDownList;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }
        public void Infix_Prefix()
        {

        }
        public void Infix_Postfix()
        {
            Stack_Operators.Items.Clear();
            string MyChar = string.Empty; ;
            for (int i = 0; i < Equation_TextBox.Text.Length; i++)
            {
                MyChar = Equation_TextBox.Text.Substring(i, 1);
                if (MyChar == "(" || MyChar == "*" || MyChar == "/" || MyChar == "+" || MyChar == "-")
                {
                    Stack_Operators.Items.Add(MyChar);
                }
                else if (MyChar != " ")
                {
                    Answer_TextBox.Text += MyChar;
                }
                else
                {

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Methods.SelectedIndex == -1 || Equation_TextBox.Text == string.Empty)
            {
                MessageBox.Show("Select one method or enter input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Equation_TextBox.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Enter your equation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Methods.SelectedIndex == 1)
                    {
                        Infix_Postfix();
                    }
                }
            }
            
        }

        private void Methods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Methods.SelectedIndex == 0)
            {
                lblEquation.Text = "Infix:";
                lblAnswer.Text = "Prefix:";
                Equation_TextBox.Enabled = true;
            }
            else if (Methods.SelectedIndex == 1)
            {
                Equation_TextBox.Enabled = true;

                lblEquation.Text = "Infix:";
                lblAnswer.Text = "Postfix:";
            }
            else if (Methods.SelectedIndex == 2)
            {
                Equation_TextBox.Enabled = true;

                lblEquation.Text = "Prefix:";
                lblAnswer.Text = "Infix:";
            }
            else if (Methods.SelectedIndex == 3)
            {
                Equation_TextBox.Enabled = true;

                lblEquation.Text = "Postfix:";
                lblAnswer.Text = "Infix:";
            }
            else if (Methods.SelectedIndex == 4)
            {
                Equation_TextBox.Enabled = true;

                lblEquation.Text = "Prefix:";
                lblAnswer.Text = "Postfix:";
            }
            else if (Methods.SelectedIndex == 5)
            {
                Equation_TextBox.Enabled = true;

                lblEquation.Text = "Postfix:";
                lblAnswer.Text = "Prefix:";
            }
        }
    }
}
