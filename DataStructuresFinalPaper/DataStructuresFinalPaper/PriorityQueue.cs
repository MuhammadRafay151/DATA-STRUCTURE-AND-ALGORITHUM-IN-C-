using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalPaper
{
    class PriorityQueue
    {
        LinkedList<vertex> l1 = new LinkedList<vertex>();
        public void Enqueue(vertex data)
        {
            l1.AddLast(data);
        }
        public vertex extractmin()
        {
            if (l1.Count == 0)
                throw new Exception("Queue is empty");
            vertex[] v = l1.ToArray<vertex>();
            vertex min = v[0];
            foreach (vertex x in v)
            {
                if (min.weight > x.weight)
                    min = x;
            }
            l1.Remove(min);
            return min;
        }
        public int count
        {
            get { return l1.Count; }
        }
    }

}

