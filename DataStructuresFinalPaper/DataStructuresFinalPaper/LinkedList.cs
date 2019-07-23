using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalPaper
{
    class LinkedList
    {
      protected  Node head;
        Node tail;
      public  int count;
        public LinkedList()
        {
            head = new Node();
            tail = head;
        }
        public void AddLast(int data)
        {
            Node newnode = new Node(data);
            tail.next = newnode;
            tail = newnode;
            count++;
        }
        public void AddFirst(int data)
        {
            Node newnode = new Node(data);
            if (head.next == null)
            {
                tail.next = newnode;
                tail = newnode;
                count++;
            }
            else
            {
                newnode.next = head.next;
                head.next = newnode;
                count++;
            }
        }
        public void Traverse()
        {
            Node node = head;
            while (node.next != null)
            {
                node = node.next;
                Console.WriteLine(node.data);
            }
        }
        public void Deletefirst()
        {if (head.next == null)
                throw new Exception("List is empty");
            if (head.next==tail)
            {
                tail = head;
            }
            head.next = head.next.next;
            --count;
        }
        public void DeleteLast()
        {
            Node node = head;
            while (node.next != null && node.next != tail)
            {
                node = node.next;
            }
            node.next = null;
            tail = node;
            if (count > 0)
                count--;
            

        }
        public int GetFirst
        {
            get { return head.next.data; }
        }

    }
}
