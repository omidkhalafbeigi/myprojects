using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp1
{ //Disconnected method
    class Program
    {
        public const string connectionString = "Data Source=desktop-eupgkmt;Initial Catalog=Student;Integrated Security=True";
        public static void DB_ReadData(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Dispose();
            dataSet.Dispose();
            command.Connection = connection;
            connection.Open();
            command.CommandText = "Select * from [Student_Table]";
            adapter.SelectCommand = command;
            adapter.Fill(dataSet);
            connection.Close();
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                foreach (DataColumn column in dataSet.Tables[0].Columns)
                {
                    Console.Write
                        ($"{column.ColumnName}: {dataSet.Tables[0].Rows[i][column.ColumnName]} - ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n------");
        }

        public static void DB_DeleteData(int ID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Dispose();
            dataSet.Dispose();
            command.Connection = connection;
            connection.Open();
            command.CommandText = "Select * from [Student_Table]";
            adapter.SelectCommand = command;
            adapter.Fill(dataSet);
            connection.Close();
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                if (string.Equals(dataSet.Tables[0].Rows[i]["ID"].ToString(), ID.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    dataSet.Tables[0].Rows[i].Delete();
                    
                }
            }
            Console.WriteLine("Deleted!");
        }

        public static void DB_InsertData(string connectionString, int ID, string Name, string Lastname, int Age)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Dispose();
            dataSet.Dispose();
            command.Connection = connection;
            connection.Open();
            command.CommandText = "Select * from [Student_Table]";
            adapter.SelectCommand = command;
            adapter.Fill(dataSet);
            connection.Close();
            DataRow dataRow = dataSet.Tables[0].NewRow();
            dataRow["ID"] = ID;
            dataRow["Name"] = Name;
            dataRow["Lastname"] = Lastname;
            dataRow["Age"] = Age;
            dataSet.Tables[0].Rows.Add(dataRow);
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                foreach (DataColumn column in dataSet.Tables[0].Columns)
                {
                    Console.Write($"{column.ColumnName}: {dataSet.Tables[0].Rows[i][column.ColumnName]} - ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------");

        }

        static void Main()
        {
            DB_ReadData(connectionString);
            Console.Write("Enter ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Lastname: ");
            string Lastname = Console.ReadLine();
            Console.Write("Enter Age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            DB_InsertData(connectionString, ID, Name, Lastname, Age);
            Console.ReadKey();
        }
    }
}
