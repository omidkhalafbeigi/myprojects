using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


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
        

        public string Infix_Postfix(string Equation) //Infix -> Postfix
        {
            //(a + (b * x))
            string Answer = string.Empty;
            Stack stack = new Stack(Equation.Length - 1);
            string MyChar = string.Empty;
            for (int i = 0; i < Equation.Length; i++)
            {
                MyChar = Equation.Substring(i, 1);
                if (MyChar == "(" || MyChar == "*" || MyChar == "/" || MyChar == "+" || MyChar == "-" || MyChar == "^")
                {
                    List_Operators.Items.Add(MyChar);
                    stack.Push(MyChar);
                }
                else if (MyChar != " " && MyChar != ")")
                {
                    Answer += MyChar;
                }
                if (MyChar == ")")
                {
                    string Pop = stack.Pop();
                    while (Pop != "(")
                    {
                        Answer += Pop;
                        Pop = stack.Pop();
                    }
                }
            }
            return Answer;
        }
        //((c*(a-b))/((c^d)^x))
        public string Infix_Prefix(string Equation) //Infix -> Prefix
        { //( a + ( b * x ))
            string Answer = string.Empty;
            string EveryChar = string.Empty;
            for (int i = 0; i < Equation.Length; i++)
            {
                EveryChar = Equation.Substring(i, 1);
                if (EveryChar == "(" || EveryChar == "*" || EveryChar == "/" || EveryChar == "+" || EveryChar == "-" || EveryChar == "^")
                {
                    List_Operators.Items.Add(EveryChar);
                }
                else if (EveryChar != " " && EveryChar != ")")
                {
                    List_Operands.Items.Add(EveryChar);
                }
                else
                {
                    continue;
                }
            }
            Stack Operators = new Stack(List_Operators.Items.Count);
            Stack Operands = new Stack(List_Operands.Items.Count);

            string Operator = string.Empty;
            string Operand1 = string.Empty;
            string Operand2 = string.Empty;

            // (a + (b * x))
            // (a + ( b * ( d ^ c ) ) )
            // ( ( a ^ ( c ^ d ) ) - ( x ^ c ) )


            for (int i = 0; i < Equation.Length; i++)
            {
                EveryChar = Equation.Substring(i, 1);
                if (EveryChar == "(" || EveryChar == "*" || EveryChar == "/" || EveryChar == "+" || EveryChar == "-" || EveryChar == "^")
                {
                    Operators.Push(EveryChar);
                }
                else if (EveryChar != " " && EveryChar != ")")
                {
                    Operands.Push(EveryChar);
                }
                if (EveryChar == ")")
                {
                    Operand1 = Operands.Pop();
                    Operand2 = Operands.Pop();
                    Operator = Operators.Pop();
                    while (Operator != "(")
                    {
                        Operands.Push(Operator + Operand2 + Operand1);
                        Operator = Operators.Pop();
                    }
                    //if (Operator != "(")
                    //{
                    //    Operands.Push(Operator + Operand2 + Operand1);
                    //}
                    //else
                    //{
                    //    Operands.Push(Operators.Pop() + Operand2 + Operand1);
                    //}
                }
            }//( ( c * ( a - b ) ) / ( ( c ^ d ) ^ x ) )

            Answer = Operands.Pop();

            return Answer;
        }
        // (a + (b * x))
        // (a + ( b * ( d ^ c ) ) )
        // ( ( a ^ ( c ^ d ) ) - ( x ^ c ) )
        public string Postfix_Infix(string Equation) //Postfix -> Infix
        {
            Stack stack = new Stack(Equation.Length - 1);
            string Answer = string.Empty;
            string EveryChar = string.Empty;
            string Operand1 = string.Empty;
            string Operand2 = string.Empty;
            string Operator = string.Empty;
            for (int i = 0; i < Equation.Length; i++)
            {
                EveryChar = Equation.Substring(i, 1);
                if (EveryChar != "*" && EveryChar != "/" && EveryChar != "+" && EveryChar != "-" && EveryChar != "^" && EveryChar != " " && EveryChar != string.Empty)
                {
                    stack.Push(EveryChar);
                    List_Operands.Items.Add(EveryChar);
                }
                else if (EveryChar == "*" || EveryChar == "/" || EveryChar == "+" || EveryChar == "-" || EveryChar == "^")
                {
                    Operator = EveryChar;
                    Operand1 = stack.Pop();
                    Operand2 = stack.Pop();
                    stack.Push($"({Operand2 + Operator + Operand1})");
                    List_Operands.Items.Add($"({Operand2 + Operator + Operand1})");
                }
            }
            Answer = stack.Peek();
            return Answer;
        }
        // (a + (b * x))
        // (a + ( b * ( d ^ c ) ) )
        // ( ( a ^ ( c ^ d ) ) - ( x ^ c ) )
        public string Prefix_Infix(string Equation)
        {
            Stack stack = new Stack(Equation.Length - 1);
            string Answer = string.Empty;
            string EveryChar = string.Empty;
            string Operand1 = string.Empty;
            string Operand2 = string.Empty;
            string Operator = string.Empty;

            for (int i = Equation.Length - 1; i >= 0; i--)
            {
                EveryChar = Equation.Substring(i, 1);
                if (EveryChar != "*" && EveryChar != "/" && EveryChar != "+" && EveryChar != "-" && EveryChar != "^" && EveryChar != " " && EveryChar != string.Empty)
                {
                    stack.Push(EveryChar);
                    List_Operands.Items.Add(EveryChar);
                }
                else if (EveryChar == "*" || EveryChar == "/" || EveryChar == "+" || EveryChar == "-" || EveryChar == "^")
                {
                    Operator = EveryChar;
                    Operand1 = stack.Pop();
                    Operand2 = stack.Pop();
                    stack.Push($"({Operand1 + Operator + Operand2})");
                    List_Operands.Items.Add($"({Operand1 + Operator + Operand2})");
                }
            }
            Answer = stack.Peek();
            return Answer;
        }

        public string Prefix_Postfix(string Equation) // Prefix -> Infix -> Postfix
        {
            string Postfix = string.Empty;
            string Infix = string.Empty;

            Infix = Prefix_Infix(Equation);
            Postfix = Infix_Postfix(Infix);

            return Postfix;
        }

        public string Postfix_Prefix(string Equation) // Postfix -> Infix -> Prefix
        {
            string Prefix = string.Empty;
            string Infix = string.Empty;

            Infix = Postfix_Infix(Equation);
            Prefix = Infix_Prefix(Infix);

            return Prefix;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string Prefix, Postfix; Prefix = Postfix = string.Empty;
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
                    List_Operators.Items.Clear();
                    List_Operands.Items.Clear();
                    Answer_TextBox.Clear();
                    if (Methods.SelectedIndex == 0) //Infix -> Prefix
                    {
                        Answer_TextBox.Text = Infix_Prefix(Equation_TextBox.Text);
                    }
                    else if (Methods.SelectedIndex == 1) //Infix -> Postfix
                    {
                        Answer_TextBox.Text = Infix_Postfix(Equation_TextBox.Text);
                    }
                    else if (Methods.SelectedIndex == 2) //Prefix -> Infix
                    {
                        Answer_TextBox.Text = Prefix_Infix(Equation_TextBox.Text);
                    }
                    else if (Methods.SelectedIndex == 3) //Postfix -> Infix
                    {
                        Answer_TextBox.Text = Postfix_Infix(Equation_TextBox.Text);
                    }
                    else if (Methods.SelectedIndex == 4) //Prefix -> Postfix
                    {
                        Answer_TextBox.Text = Prefix_Postfix(Equation_TextBox.Text);
                    }
                    else if (Methods.SelectedIndex == 5) //Postfix -> Prefix
                    {
                        Answer_TextBox.Text = Postfix_Prefix(Equation_TextBox.Text);
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