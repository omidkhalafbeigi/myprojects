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
            int Num = Convert.ToInt32(Console.ReadLine());
            int Result = 1;
            for (int i = Num; i > 1; --i)
            {
                Result *= (i);
            }
            Console.Write(Result.ToString());
            Console.ReadKey();
        }
    }
}
