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
            for (int i = 10; i >=1; i--)
            {
                for (int j = 10; j >= i; j--)
                {
                    Console.Write(j.ToString());
                }
                for (int j = 1; j < i; j++)
                {
                    Console.Write(i.ToString());
                }
                Console.Write(Environment.NewLine);
            }
            Console.Write("\nTik Tok :)");
            Console.ReadKey();
        }
    }
}
