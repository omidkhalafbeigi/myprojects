using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jahad_Project__Grade_of_Students_
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Grades = new double[15];
            double Max = 20; double Min = 0; double Sum = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.Write($"Enter grade of student {(i + 1).ToString()}: ");
                Grades[i] = Convert.ToDouble(Console.ReadLine());
                Sum += Grades[i];
                if (i == 0)
                {
                    Max = Grades[0];
                    Min = Grades[0];
                }
                else
                {
                    Max = Math.Max(Max, Grades[i]);
                    Min = Math.Min(Min, Grades[i]);
                }
            }
            Console.WriteLine($"Max: {Max.ToString()}");
            Console.WriteLine($"Min: {Min.ToString()}");
            Console.WriteLine($"Distance: {(Max - Min).ToString()}");
            Console.WriteLine($"Sum: {Sum.ToString()}");
            Console.WriteLine($"Average: {(Sum / 15).ToString()}");

            Console.ReadKey();
        }
    }
}
