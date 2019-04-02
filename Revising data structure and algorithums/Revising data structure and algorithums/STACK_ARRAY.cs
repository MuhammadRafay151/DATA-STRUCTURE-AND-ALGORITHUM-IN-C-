using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revising_data_structure_and_algorithums
{
    class STACK_ARRAY<T>
    {//Implementation of stack with using array.
        //Generic implementation..
        T[] data;
        int l = 0;
        int count = 0;
        public STACK_ARRAY(int TotalValues)
        {
            data = new T[TotalValues];
        }
        public void Push(T data)
        {if (count == this.data.Length)
                throw new StackOverflowException();
            this.data[l] = data;
            l += 1;
            count++;
        }
        public T pop()
        {if (count == 0)
                throw new Exception("Stack in underflow condition");
            count--;
            return this.data[l -= 1];
        }
        public int Count
        {
            get { return count; }
        }
    }
}
