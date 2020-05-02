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
            Console.Write("Enter your number: ");
            
            int Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Power: {(Number * Number).ToString()}");
            Console.WriteLine($"10 times: {(Number * 10).ToString()}");

            Console.ReadKey();
        }
    }
}