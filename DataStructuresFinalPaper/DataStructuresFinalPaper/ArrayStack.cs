using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalPaper
{
   class ArrayStack
    {
        int[] Array;
        int l = 0;
        public ArrayStack(int NumberOfElments)
        {
            Array = new int[NumberOfElments];
        }
        public void Push(int n)
        {if (l == Array.Length)
                throw new StackOverflowException();
            Array[l] = n;
            l++;
        }
        public int Pop()
        {if (IsEmpty())
                throw new Exception("Stack Is Empty");
            return Array[l = l - 1];
        }
        public bool IsEmpty()
        {
            return l == 0;
        }
    }
}
