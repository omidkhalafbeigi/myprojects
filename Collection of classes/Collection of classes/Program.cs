using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_of_classes
{

    class Program
    {

        class Parent : CollectionBase
        {
            public void Add(Child child)
            {
                List.Add(child);
            }
            public void Remove(Child child)
            {
                List.Remove(child);
            }
            public Child this[int Index]
            {
                get { return (Child)List[Index]; }
                set { List[Index] = value; }
            }
        }

        class Child
        {
            public string Name;
        }


        static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.Add(new Child() { Name = Console.ReadLine() });
            Console.Write(parent[0].Name);
            Console.ReadKey();
        }
    }
}
