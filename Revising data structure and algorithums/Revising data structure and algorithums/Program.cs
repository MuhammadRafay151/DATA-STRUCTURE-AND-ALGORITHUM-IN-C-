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
            Program.StackArray();
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
    }
}
