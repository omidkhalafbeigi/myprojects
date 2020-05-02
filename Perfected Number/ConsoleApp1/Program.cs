using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            for (int i = 2; i <= Number; ++i)
            {
                if (Number % i == 0)
                {
                    Sum += (Number / i);
                }
            }
            if (Sum == Number)
            {
                Console.Write("Your number is perfected.");
            }
            else
            {
                Console.WriteLine("Your number isn't perfected.");
            }


            Console.ReadKey();
        }
    }
}
