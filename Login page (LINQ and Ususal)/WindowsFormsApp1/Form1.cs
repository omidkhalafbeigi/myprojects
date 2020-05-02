using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const string connectionString = "Data Source=desktop-eupgkmt;Initial Catalog=Test;Integrated Security=True";

        public struct account_info
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        private void button1_Click(object sender, EventArgs e) //Query usual method
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command.Connection = connection;
            command.CommandText = "Select * from [Account_Table]";
            adapter.SelectCommand = command;
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {

                if (table.Rows[i]["Username"].Equals(textBox1.Text) && table.Rows[i]["Password"].Equals(textBox2.Text))
                {
                    MessageBox.Show("Logged in!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else if (i == table.Rows.Count - 1)
                {
                    MessageBox.Show("Enter true data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { }
            }

        }

        private void button2_Click(object sender, EventArgs e) //Query LINQ method
        {
            List<account_info> accounts_list = new List<account_info>();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command.Connection = connection;
            command.CommandText = "Select * from [Account_Table]";
            adapter.SelectCommand = command;
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                accounts_list.Add(new account_info() { Username = table.Rows[i]["Username"].ToString(), Password = table.Rows[i]["Password"].ToString() });
                var data = from account in accounts_list where (account.Username.Equals(textBox1.Text) && account.Password.Equals(textBox2.Text)) select account;
                foreach (var account in data)
                {
                    MessageBox.Show($"{account.Username}: {account.Password}");
                }
                break;
            }
        }
    }
}
