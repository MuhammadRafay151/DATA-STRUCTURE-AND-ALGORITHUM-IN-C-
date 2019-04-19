using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revising_data_structure_and_algorithums
{
    class LinkedListNode<T>
    {//Implemting generic form of linked list
        public LinkedListNode(T data)
        {
            this.data = data;
        }
        public LinkedListNode()
        {

        }
        T data;
        public LinkedListNode<T> Next;
        public T Data
        {
            get { return data; }
        }
    }
}
