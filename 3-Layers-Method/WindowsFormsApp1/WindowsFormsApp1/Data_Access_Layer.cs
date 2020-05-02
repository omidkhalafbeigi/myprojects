using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace WindowsFormsApp1
{
    class Data_Access_Layer
    {
        public DataTable ReadData()
        {
            SqlCeConnection connection = new SqlCeConnection(@"Data Source=C:\Users\pq\Desktop\Test.sdf");
            SqlCeCommand command = new SqlCeCommand();
            SqlCeDataAdapter adapter = new SqlCeDataAdapter();
            DataTable data = new DataTable();
            command.Connection = connection;
            connection.Open();
            command.CommandText = "Select * from [Info_Table]";
            adapter.SelectCommand = command;
            adapter.Fill(data);
            connection.Close();

            return data;

        }
    }
}
