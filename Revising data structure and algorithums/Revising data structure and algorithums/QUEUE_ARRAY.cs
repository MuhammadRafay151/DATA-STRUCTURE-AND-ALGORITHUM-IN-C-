using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revising_data_structure_and_algorithums
{
    class QUEUE_ARRAY<T>
    {/// <summary>
    /// Queue store data in fifo order
    /// </summary>
        T[] data;
        int Tail = 0;
        int Head = 0;
        int count = 0;
        public QUEUE_ARRAY(int TotalValues)
        {
            data = new T[TotalValues];
        }
        public void Enqueue(T data)
        {
            if (count == this.data.Length)
                throw new Exception("Queue full");
            this.data[Tail] = data;
            Tail = (Tail + 1) % this.data.Length;
            ++count;
        }
        public T Dequeue()
        {
            if(count==0)
            {
                throw new Exception("Queue is empty");
            }
            T temp = data[Head];
            Head=(Head+1)% data.Length;
            count--;
            return temp;
        }
        public int Count
        {
            get { return count; }
        }
    }
}
