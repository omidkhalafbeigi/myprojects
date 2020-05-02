using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Hashtable hashtable = new Hashtable();
            hashtable["a"] = "Omid";
            hashtable.Add("b", "Navid");
            
            foreach (DictionaryEntry v in hashtable)
            {
                Console.WriteLine(v.Key.ToString());
                Console.WriteLine(v.Value.ToString());
            }

            Console.ReadKey();

        }
    }
}
