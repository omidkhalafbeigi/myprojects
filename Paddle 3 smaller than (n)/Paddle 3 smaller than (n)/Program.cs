using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paddle_3_smaller_than__n_
{

    abstract class PaddleClass
    {
        public static int PaddleFunction(int n)
        {
            for (int i = 1; i <= n; i += 1)
            {
                if ((i % 3) == 0)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            return 0;
        }
    }
    class Program : PaddleClass
    {

        static void Main(string[] args)
        {
            //Printing numbers smaller than (n) that are paddle 3 (By recursive function.)
            Console.Write("Input number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Program.PaddleFunction(n);
            Console.ReadKey();
        }
    }
}
