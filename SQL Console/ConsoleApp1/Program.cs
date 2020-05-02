using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ConsoleApp1
{
    abstract class SQL
    {
        protected void Insert(string Name, int Age)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=.;Initial Catalog=Test DB;Integrated Security=True");
            SqlCommand Command = new SqlCommand("Insert into Data(Name,Age) values(@n, @a)", Connection);
            Command.Parameters.Add(new SqlParameter("@n", Name));
            Command.Parameters.Add(new SqlParameter("@a", Age));
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            Console.Write("Inserted!");

        }
        protected void Select()
        {
            SqlConnection Connection = new SqlConnection("Data Source=.;Initial Catalog=Test DB;Integrated Security=True");
            SqlCommand Command = new SqlCommand("Select * from Data", Connection);
            Connection.Open();
            SqlDataReader Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                object[] s = new object[Reader.FieldCount];
                
                    Reader.GetValues(s);
                    foreach (object ss in s)
                    {
                        Console.WriteLine(ss);
                    }
                    Console.Write("Done!");
                
            }
            else
            {
                throw new MissingFieldException();
            }
            Connection.Close();
        }
        protected void Delete(string Name)
        {
            SqlConnection Connection = new SqlConnection("Data Source=.;Initial Catalog=Test DB;Integrated Security=True");
            SqlCommand Command = new SqlCommand("Delete from Data where Name = @n", Connection);
            Command.Parameters.Add(new SqlParameter("@n", Name));
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            Console.Write("Deleted!");
        }
        protected void Update(string New_Name, string Old_Name)
        {
            SqlConnection Connection = new SqlConnection("Data Source=.;Initial Catalog=Test DB;Integrated Security=True");
            SqlCommand Command = new SqlCommand("Update Data Set Name = @nn Where Name = @on", Connection);
            Command.Parameters.Add(new SqlParameter("@nn", New_Name));
            Command.Parameters.Add(new SqlParameter("@on", Old_Name));
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            Console.Write("Updated!");
        }

    }

    class Program : SQL
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your command: ");
            string User_Command = Console.ReadLine(); string Name, Old_Name = null; int Age = 0;
            switch (User_Command)
            {
                case "Insert":
                    Console.Write("Enter name: ");
                    Name = Console.ReadLine(); Console.Write("Enter age: "); Age = Convert.ToInt32(Console.ReadLine());
                    new Program().Insert(Name, Age);
                    break;
                case "Select":
                    new Program().Select();
                    break;
                case "Delete":
                    Console.Write("Enter new name: ");
                    Name = Console.ReadLine();
                    new Program().Delete(Name);
                    break;
                case "Update":
                    Console.Write("Enter name: ");
                    Name = Console.ReadLine();
                    Console.Write("Enter old name: ");
                    Old_Name = Console.ReadLine();
                    new Program().Update(Name, Old_Name);
                    break;
                    
            }
            Console.ReadKey();
        }
    }
}
