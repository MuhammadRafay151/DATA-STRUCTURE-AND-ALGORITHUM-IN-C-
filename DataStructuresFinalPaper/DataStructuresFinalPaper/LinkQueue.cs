using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalPaper
{
    class LinkQueue
    {
        LinkedList l1 = new LinkedList();
        public void Enqueue(int data)
        {
            l1.AddLast(data);
        }
        public int Dequqe()
        {
            if (l1.count == 0)
                throw new Exception("Queue is empty");
            int temp = l1.GetFirst;
            l1.Deletefirst();
            return temp;
        }
    }
}
