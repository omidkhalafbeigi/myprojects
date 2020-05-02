using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //برنامه ای بنویسید که شماره روز را از کاربر گرفته و نام روز را چاپ کند 
            Console.Write("Enter Day Number: ");
            int Num_Day = Convert.ToInt32(Console.ReadLine());
            if (Num_Day > 6)
            {
                Console.WriteLine("Enter true number.");
            }
            else
            {
                switch (Num_Day)
                {
                    case 0:
                        Console.Write("Saturday");
                        break;
                    case 1:
                        Console.Write("Sunday.");
                        break;
                    case 2:
                        Console.Write("Monday.");
                        break;
                    case 3:
                        Console.Write("Tuesday.");
                        break;
                    case 4:
                        Console.Write("Wednesday.");
                        break;
                    case 5:
                        Console.Write("Thursday.");
                        break;
                    case 6:
                        Console.Write("Friday.");
                        break;
                }
            }


            Console.ReadKey();

        }
    }
}
