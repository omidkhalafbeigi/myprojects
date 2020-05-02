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
            while (true)
            {
                Console.Write("Enter current price: ");
                double Current = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter former price: ");
                double Former = Convert.ToDouble(Console.ReadLine());
                double Rate = ((Current - Former) / Former);
                double New = ((Current + Former) / Rate);
                Console.WriteLine("Rate: {0} - New Price: {1}", Rate.ToString(), New.ToString());
                Console.Write("Continue? Y/N: ");
                int Logical = Console.ReadLine() == "Y" ? 1 : 0;
                if (Logical == 0)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
