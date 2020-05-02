using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //     ***
    //   *     *  
    // *         *
    //*           *   
    //*           *
    //*           *
    //*           *
    //*           *
    //*           *
    //*           *
    //*           *
    // *         *
    //   *     *
    //     ***
    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 8; i >= 1; --i)
            {
                for (int j = 1; j <= i - 3; ++j) //چاپ هر سطر و فاصله
                {
                    if (i <= 4)
                    {
                        continue; //پریدن از چاپ فاصله (برای ستاره هایی که در گوشه قرار دارند)
                    }
                    Console.Write(" ");
                }
                if (i == 7) //چاپ اولین ستاره سطر
                {
                    Console.Write("*");
                    Console.Write("*");
                }
                Console.Write("*");
                if (i == 6)
                {
                    for (int j = 1; j <= 3; ++j)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                if (i == 5)
                {
                    for (int j = 1; j <= 5; ++j)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                if (i == 4)
                {
                    for (int j = 1; j <= 9; ++j)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                if (i < 4) //چاپ چهار ستاره در نیمه راست
                {
                    for (int j = 1; j <= 9; ++j)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (int i = 1; i <= 7; ++i)
            {
                if (i < 5)
                {
                    Console.Write("*");
                    for (int j = 1; j <= 9; ++j)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    Console.Write("\n");
                }
                else
                {
                    if (i == 5)
                    {
                        Console.Write("  *");
                        for (int j = 1; j <= 5; ++j)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("*");
                    }
                    if (i == 6)
                    {
                        Console.Write("   *");
                        for (int j = 1; j <= 3; ++j)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("*");
                    }
                    if (i == 7)
                    {
                        for (int j = 1; j <= 4; ++j)
                        {
                            Console.Write(" ");

                        }
                        Console.WriteLine("***");
                        for(int j = 1; j <= 5; ++j)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                    }
                }
        }
            Console.ReadKey();
        }
    }
}

