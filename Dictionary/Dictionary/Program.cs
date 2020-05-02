using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Dictionary
{
    class MyDictionary : DictionaryBase
    {
        public void Add(string Key, string Value)
        {
            Dictionary.Add(Key, Value);
        }
        public void Remove(string Key)
        {
            Dictionary.Remove(Key);
        }

        public object this[string Key]
        {
            get { return Dictionary[Key]; }
            set { Dictionary[Key] = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary dictionary = new MyDictionary();
            dictionary.Add("a", "Omid");
            dictionary.Add("b", "Navid");
            Console.WriteLine(dictionary["b"]);
            Console.ReadKey();
        }
    }
}
