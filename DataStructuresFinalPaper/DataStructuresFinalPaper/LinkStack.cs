using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalPaper
{
    class LinkStack
    {
        LinkedList l1 = new LinkedList();
        public void push(int data)
        {
            l1.AddFirst(data);
        }
        public int pop()
        {
            if (l1.count == 0)
                throw new Exception("Stack is underflow");
            int temp = l1.GetFirst;
            l1.Deletefirst();
            return temp;
        }
    }
}
