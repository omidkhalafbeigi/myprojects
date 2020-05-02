using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_using_for_question
{

    abstract class FactorialClass
    {
        public static int Factorial_1(int n, int m)
        {
            int n_Result = n - 1; int m_Result = (n - m) - 1;
            for (int i = n - 2; i >= 1; --i)
            {
                n_Result *= i;
            }
            for (int i = (n - m) - 2; i >= 1; --i)
            {
                m_Result *= i;
            }
            return (n_Result / m_Result);
        }

        public static int Factorial_2(int n, int m)
        {
            int n_Result = n - 1; int m_Result = n - m;
            for (int i = n - 2; i >= 1; --i)
            {
                n_Result *= i;
            }
            for (int i = (n - m) - 1; i >= 1; --i)
            {
                m_Result *= i;
            }
            return (n_Result / m_Result);
        }


        public static int FactorialFunction(int n, int m)
        {
            if (m == n)
            {
                return 1;
            }
            else if (m == 0)
            {
                return 0;
            }
            else
            {
                return (Program.Factorial_1(n, m) + Program.Factorial_2(n, m));
            }
        }
    }
    class Program : FactorialClass
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write(Program.FactorialFunction(n, m));
            Console.ReadKey();
        }
    }
}
