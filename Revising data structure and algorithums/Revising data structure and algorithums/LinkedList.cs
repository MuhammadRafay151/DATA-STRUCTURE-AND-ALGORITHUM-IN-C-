using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revising_data_structure_and_algorithums
{
    class LinkedList<T>
    {/// <summary>
    /// Add First takes O(1)
    /// Add Last takes O(1)
    /// Delte Last takes O(n)
    /// Delte first takes O(1)
    /// Return Array Takes O(1)
    /// </summary>
        public LinkedList()
        {
            head = new LinkedListNode<T>();
            Tail = head;
        }
        private int count = 0;
        LinkedListNode<T> head;
        LinkedListNode<T> Tail;
        public void AddLast(T data)
        {
            LinkedListNode<T> Node = new LinkedListNode<T>(data);
            Tail.Next = Node;
            Tail = Node;
            ++count;
        }
        public void AddFirst(T data)
        {
            LinkedListNode<T> Node = new LinkedListNode<T>(data);
            Node.Next = head.Next;
            head.Next = Node;
            ++count;
        }
        public T GetFirst
        {
            get { return head.Next.Data; }
        }
        public T GetLast
        {
            get { return Tail.Data; }
        }
        public T[] ToArray()
        {
            if (count == 0)
                throw new Exception("List is Empty Can't Return Array");
            T[] Array = new T[count];
            LinkedListNode<T> node = head.Next;
            for (int i = 0; node != null; i++)
            {
                Array[i] = node.Data;
                node = node.Next;
            }
            return Array;
        }
        public void DeleteLast()
        {if(count==0)
            throw new Exception("List Is Empty Can't Delete Last");
            LinkedListNode<T> Node = head;
            while(Node.Next!=Tail)
            {
                Node = Node.Next;
            }
            Node.Next = null;
            Tail = Node;
            --count;
            
        }
        public void DeleteFirst()
        {if(count==0)
                throw new Exception("List Is Empty Can't Delete Last");

            //LinkedListNode<T> Node = head.Next.Next;
            //head.Next = null;
            //head.Next = Node;
            //or the below code also works the code above is for the understanding of beginners.
            head.Next = head.Next.Next;
            --count;
        }

    }
}
