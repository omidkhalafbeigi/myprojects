using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.Sql;

namespace Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlCeConnection Connection = new SqlCeConnection();
            Connection.ConnectionString = @"Data Source=D:\Projects\Employee\Employee\Employee.sdf";
            SqlCeCommand Command = new SqlCeCommand();
            Command.Connection = Connection;
            Command.CommandText = "Insert into [user9](Id,Name,Lastname,Address,Phone) values('@i', '@n', '@l', '@a', '@p')";
            if (txtID.Text == string.Empty || txtAddress.Text == string.Empty || txtName.Text == string.Empty || txtLastname.Text == string.Empty || txtPhone.Text == string.Empty)
            {
                MessageBox.Show("Enter all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Command.Parameters.AddWithValue("@i", txtID.Text);
                Command.Parameters.AddWithValue("@n", txtName.Text);
                Command.Parameters.AddWithValue("@l", txtLastname.Text);
                Command.Parameters.AddWithValue("@a", txtAddress.Text);
                Command.Parameters.AddWithValue("@p", txtPhone.Text);
                //Command.Parameters.AddWithValue("@image", null);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
                MessageBox.Show("Employee information inserted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "JPG File (*.jpg)|*.jpg";
            Open.Title = "Select image";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(Open.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
