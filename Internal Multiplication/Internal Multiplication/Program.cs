using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Every matrix fill: row by row (First columns then rows)

            Console.Write("Enter rows number: ");
            byte Rows = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter columns number: ");
            byte Columns = Convert.ToByte(Console.ReadLine());

            int[,] Matrix1 = new int[Rows, Columns];
            int[,] Matrix2 = new int[Rows, Columns];
            int[,] Result = new int[Rows, Columns];

            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    Console.Write("Row {0} and Column {1} in matrix1 value: ", (i + 1).ToString(), (j + 1).ToString());
                    Matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Row {0} and Column {1} in matrix2 value: ", (i + 1).ToString(), (j + 1).ToString());
                    Matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    Result[i, j] = Matrix1[i, j] * Matrix2[i, j];
                }
            }

            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    Console.Write(Result[i, j] + "    ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
