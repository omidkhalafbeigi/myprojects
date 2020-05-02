using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> Numbers = new Queue<int>();
            Numbers.Enqueue(20);
            Numbers.Enqueue(10);
            Numbers.Enqueue(5);
            Numbers.Dequeue();
            foreach(int Number in Numbers)
            {
                Console.WriteLine(Number.ToString());
            }
            Console.WriteLine("-----");
            Stack<int> numbers = new Stack<int>();
            numbers.Push(20);
            numbers.Push(10);
            numbers.Push(5);
            numbers.Pop();
            foreach (int Number in numbers)
            {
                Console.WriteLine(Number.ToString());
            }
            Console.WriteLine("-----");
            LinkedList<int> numbersList = new LinkedList<int>();
            numbersList.AddFirst(20);
            numbersList.AddFirst(10);
            foreach (int number in numbersList)
            {
                Console.WriteLine(number.ToString());
            }
            Console.ReadKey();
        }
    }
}
