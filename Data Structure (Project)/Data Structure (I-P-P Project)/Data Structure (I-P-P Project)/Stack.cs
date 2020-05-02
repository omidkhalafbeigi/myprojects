using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure__I_P_P_Project_
{
    class Stack
    {
        private string[] StackList;
        private int Capacity { get; set; }
        private int Counter { get; set; }
        private int Top_Count { get; set; }
        
        public Stack(int Capacity)
        {
            StackList = new string[Capacity];
            this.Capacity = Capacity;
            Counter = 0;
        }
        public void Push(string Input)
        {
            if (Counter < Capacity)
            {
                StackList[Counter] = Input;
                Top_Count = Counter;
                Counter += 1;
            }
        }
        public void Pop()
        {
            StackList[Top_Count] = string.Empty;
            Counter -= 1;
            Top_Count = Counter;
        }
        public string Peek()
        {
            return StackList[Top_Count];
        }

    }
}
