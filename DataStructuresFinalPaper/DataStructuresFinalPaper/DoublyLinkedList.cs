using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalPaper
{
    class DoublyLinkedList
    {
        DoubleNode head;
        DoubleNode tail;
        public DoublyLinkedList()
        {
            head = new DoubleNode();
            tail = head;
        }
        public void AddFirst(int data)
        {
            DoubleNode newnode = new DoubleNode(data);
            if (head.next == null)
            {
                newnode.previous = tail;
                tail.next = newnode;
                tail = newnode;
            }
            else
            {
                newnode.next = head.next;
                newnode.next.previous = newnode;
                newnode.previous = head;
                head.next = newnode;
            }
        }
        public void AddLast(int data)
        {
            DoubleNode newnode = new DoubleNode(data);
            tail.next = newnode;
            newnode.previous = tail;
            tail = newnode;
        }
        public void TraverseBackward()
        {
            DoubleNode node = tail;
            while (node != head)
            {
                Console.WriteLine(node.data);
                node = node.previous;
            }
        }
        public void TraverseForward()
        {
            DoubleNode node = head;
            while (node.next != null)
            {
                node = node.next;
                Console.WriteLine(node.data);
            }
        }
        public void DeleteLast()
        {
            if (head.next == null)
                throw new Exception("List is empty");
            tail = tail.previous;
            tail.next = null;
        }
        public void DeleteFirst()
        {
            if (head.next != null)
            {
                if (head.next == tail)
                {
                    tail = head;
                }
                head.next = head.next.next;
            }
        }
        public void deletedata(int data)
        {
            DoubleNode node = head;
            while (node.next != null)
            {
                

                if (node.next!=null&&node.next.data == data)
                {
                    if (head.next == tail)
                    {
                        tail = head;
                        head.next.previous = null;
                        head.next = null;
                        break;
                    }
                    else
                    {
                        node.next.previous = null;
                        node.next = node.next.next;
                        if(node.next!=null)
                        node.next.previous = node;
                        break;
                    }
                }
                node = node.next;
            }
        }
    }
}
