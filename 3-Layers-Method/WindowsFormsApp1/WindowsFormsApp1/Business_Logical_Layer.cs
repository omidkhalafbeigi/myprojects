using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1
{
    class Business_Logical_Layer
    {
        public string[] Read()
        {
            Data_Access_Layer layer = new Data_Access_Layer();
            DataTable data = new DataTable();
            data = layer.ReadData();
            string[] Full_Data = new string[data.Rows.Count];

            for (int i = 0; i < data.Rows.Count; i++)
            {
                Full_Data[i] = $"{data.Rows[i]["ID"].ToString()}: {data.Rows[i]["Name"].ToString()}";
            }

            return Full_Data;
        }
    }
}
