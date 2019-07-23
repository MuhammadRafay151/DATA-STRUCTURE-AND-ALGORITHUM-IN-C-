using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalPaper
{
    class ArrayQueue
    {
        int[] Array;
        int head = 0;
        int tail = 0;
        int count = 0;
        public ArrayQueue(int NumberOfElements)
        {
            Array = new int[NumberOfElements];
        }
        public void Enqueue(int Data)
        {if (IsFull())
                throw new Exception("Queue is full");
            Array[tail] = Data;
            tail = (tail + 1) % Array.Length;
            count++;
        }
        public int DeQueue()
        {if (IsEmpty())
                throw new Exception("Queue is empty");
            int temp = Array[head];
            head=(head+1)% Array.Length;
            count--;
            return temp;
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        public bool IsFull()
        {
            return count == Array.Length;
        }
    }
}
