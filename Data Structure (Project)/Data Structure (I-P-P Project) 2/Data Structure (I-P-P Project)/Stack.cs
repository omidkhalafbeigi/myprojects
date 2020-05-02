using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structure__I_P_P_Project_
{
    class Stack
    {
        #region Variables
        private string[] StackList;
        private int Capacity { get; set; }
        private int Counter { get; set; }
        public int Count { get; set; }
        private int Top_Count { get; set; }
        #endregion
        public Stack(int Capacity)
        {
            StackList = new string[Capacity];
            this.Capacity = Capacity;
            //Count = Capacity;
            Top_Count = 0;
            Counter = 0;
            Count = 0;
        }
        public void Push(string Input)
        {
            if (Counter < Capacity)
            {
                StackList[Counter] = Input;
                Top_Count = Counter;
                Count += 1;//
                Counter += 1;
            }
        }
        public string Pop()
        {
            //string Top = StackList[Top_Count];
            //StackList[Top_Count] = string.Empty;
            if (Top_Count > 0)
            {
                Counter -= 1;
                Count -= 1;
                Top_Count = Counter;
            }
            else
            {
                Top_Count = 0;
            }
            string Top = StackList[Top_Count];
            return Top;
        }
        public string Peek()
        {
            return StackList[Top_Count];
        }
    }
}
