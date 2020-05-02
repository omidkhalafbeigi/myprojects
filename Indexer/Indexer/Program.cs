using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Indexer
{
    /// <summary>
    /// In this project, I tried to use ArrayList (no Array). Because by ArrayList we can store unlimited number of values in the array.
    /// </summary>

    class MyClass
    {
        public ArrayList array = new ArrayList();
        
        public object this[int Index]
        {
            get { return array[Index]; }
            set { array.Add(value); }
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc[0] = "My name is Omid!";
            mc[1] = 20;
            Console.WriteLine(mc[0]);
            Console.WriteLine(mc[1]);
            Console.WriteLine(mc.GetType());
            Console.ReadKey();

        }
    }
}
