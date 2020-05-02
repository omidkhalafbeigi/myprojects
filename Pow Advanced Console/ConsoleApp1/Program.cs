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
            // در بین اعداد چهاررقمی، عددی که مجموع توان یک عدد اول و توان چهار عدد چهارم برابر شود با مجموع توان سه عدد سوم و توان دو عدد دوم چاپ میشوند
            int a, b, c, d = 0;
            for (int i = 1000; i < 10000; ++i)
            {
                d = i % 10;
                c = (i / 10) % 10;
                b = ((i / 10) / 10) % 10;
                a = (((i / 10) / 10) / 10);

                if (Convert.ToInt32((Math.Pow(a, 1) + Math.Pow(d, 4))) == Convert.ToInt32((Math.Pow(b, 2) + Math.Pow(c, 3)))) 
                {
                    Console.WriteLine(i.ToString());
                }
                
            }

            Console.ReadKey();
        }
    }
}
