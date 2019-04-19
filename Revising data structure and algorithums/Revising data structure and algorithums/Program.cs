using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revising_data_structure_and_algorithums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program.BubbleSort();
            //Program.InsertionSort();
            //Program.Selection_Sort();
            //Program.StackArray();
            // Program.QueueArray();
            Program.SingleLinkedList();
        }
        //Methods for testing code
        public static void InsertionSort()
        {
            Console.WriteLine("Insertion Sort>>>>>");
            int[] Data;
            Console.Write("Enter Total Number you want to sort>>> ");
            Data = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < Data.Length; i++)
            {
                Data[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("SORTED LIST>>>>");
            SORT s1 = new SORT();
            s1.Insertion_Sort(Data);
            foreach (int i in Data)
            {
                Console.WriteLine(i);
            }
        }
        public static void Selection_Sort()
        {
            Console.WriteLine("Selection Sort>>>>>");
            int[] Data;
            Console.Write("Enter Total Number you want to sort>>> ");
            Data = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < Data.Length; i++)
            {
                Data[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("SORTED LIST>>>>");
            SORT s1 = new SORT();
            s1.Selection_Sort(Data);
            foreach(int i in Data)
            {
                Console.WriteLine(i);
            }
        }
        public static void BubbleSort()
        {
            Console.WriteLine("Bubble Sort>>>>>");
            int[] Data;
            Console.Write("Enter Total Number you want to sort>>> ");
            Data = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < Data.Length; i++)
            {
                Data[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("SORTED LIST>>>>");
            SORT s1 = new SORT();
            s1.Selection_Sort(Data);
            foreach (int i in Data)
            {
                Console.WriteLine(i);
            }
        }

        public static void StackArray()
        {
            Console.WriteLine("Enter values in stack>>>>>");
            STACK_ARRAY<int> s1 = new STACK_ARRAY<int>(5);
            
            for(int i=0;i<5;i++)
            s1.Push(int.Parse(Console.ReadLine()));
            Console.WriteLine(">>>Pop from stack in lifo order");
            while(s1.Count!=0)
            {
                Console.WriteLine(s1.pop());
            }
           
        }
        public static void QueueArray()
        {
            Console.WriteLine("Enter data in Queue>>>>");
            QUEUE_ARRAY<int> q1 = new QUEUE_ARRAY<int>(5);
            for (int i = 0; i < 5; i++)
                q1.Enqueue(int.Parse(Console.ReadLine()));
            Console.WriteLine("Printing Queue Data>>>>");
            while(q1.Count!=0)
            {
                Console.WriteLine(q1.Dequeue());
            }
        }
        public static void SingleLinkedList()
        {
            LinkedList<int> l1 = new LinkedList<int>();
            //l1.AddFirst(5);
            //l1.AddFirst(4);
            //l1.AddFirst(3);
            l1.AddLast(0);
            l1.AddLast(1);
            l1.AddLast(2);
           // Console.WriteLine(l1.GetFirst);
            //Console.WriteLine(l1.GetLast);
            //l1.DeleteLast();
            //l1.DeleteLast();
            //l1.DeleteLast();
            //l1.DeleteFirst();
            //l1.DeleteFirst();
            //l1.DeleteFirst();
            int[] array = l1.ToArray();
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

        }
    }
}
