using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Loop_Function(int n, string Type)
        {
            for (int j = 1; j <= n; ++j)
            {
                if (Type == "Star") Console.Write("*");
                else
                {
                    if (j == 1 || j == n)
                    {
                        Console.Write("*");
                        if (j == n)
                        {
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            byte n = 0;
            while (true)
            {
                Console.Write("Enter number: ");
                n = Convert.ToByte(Console.ReadLine());
                for (int i = 1; i <= n; ++i)
                {
                    if (i == 1)
                    {
                        Loop_Function(n, "Star");
                        Console.WriteLine();
                    }
                    else if (i == n)
                    {
                        Loop_Function(n, "Star");
                        Console.WriteLine();
                    }
                    else
                    {
                        Loop_Function(n, "Space");
                    }
                }
            }
        }
    }
}
