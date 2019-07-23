using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalPaper
{//bst count and height remaining
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> snake_stack = new Stack<string>();
            snake_stack.Push("Black Mammba");
            sorting s1 = new sorting();
            int[] data = new int[] { 5, 6, 9, 4 };
            s1.QuickSort(data, 0, data.Length-1);
            foreach(int i in data)
            {
                Console.WriteLine(i);
            }
           // Program.pattern();
            // C obj = new C();
           // Program.spath();
           // Program.graph();
            //Node n1 = new Node(5);
            //Node n2 = n1;
            //n2.data = 6;
            //Console.WriteLine(n1.data);
            //Program.linkstack();
            //Program.linkqueue();
            //Program.doublylinkedlist();
            //Program.bst();
            //Program.linkedList();
           //Program.arrayqueue();
           // Program.arraystack();
        }
        public static void arraystack()
        {
            //Console.WriteLine(6%7);
            ArrayStack s1 = new ArrayStack(2);
            s1.Push(6);
            s1.Push(5);
            //s1.Push(1);
            Console.WriteLine( s1.Pop());
            Console.WriteLine(s1.Pop());
         //   s1.Pop();
           // s1.Push(9);
        }
        public static void arrayqueue()
        {
            ArrayQueue q1 = new ArrayQueue(2);
              
            q1.Enqueue(6);
            q1.Enqueue(5);
            //q1.Enqueue(5);
            Console.WriteLine( q1.DeQueue());
            Console.WriteLine(q1.DeQueue());
           
        }
        public static void linkedList()
        {
            LinkedList l1 = new LinkedList();
            l1.AddFirst(4);
            l1.AddFirst(5);
            l1.AddFirst(6);
            l1.Deletefirst();
            l1.Deletefirst();
            l1.Deletefirst();
            l1.Deletefirst();

            l1.Traverse();
            
        }
        public static void linkstack()
        {
            LinkStack s1 = new LinkStack();
            s1.push(85);
            s1.push(77);
            Console.WriteLine(s1.pop());
            Console.WriteLine(s1.pop());
        //    Console.WriteLine(s1.pop());
        }
        public static void linkqueue()
        {
            LinkQueue q1 = new LinkQueue();
            q1.Enqueue(5);
            q1.Enqueue(6);
            Console.WriteLine(q1.Dequqe());
            Console.WriteLine(q1.Dequqe());
            q1.Dequqe();

        }
        public static void doublylinkedlist()
        {
            DoublyLinkedList l1 = new DoublyLinkedList();
            l1.AddFirst(1);
            l1.AddFirst(2);
            l1.AddFirst(3);
            l1.AddFirst(4);
            l1.deletedata(1);
            l1.deletedata(2);
            l1.deletedata(4);
                l1.deletedata(3);
            l1.deletedata(6);

            
            // l1.TraverseBackward();
            l1.TraverseForward();
        }
        public static void bst()
        {
            BST b1 = new BST();
            b1.Add(5);
            b1.Add(2);
            b1.Add(6);
            b1.Add(4);
            b1.Delete(6);
            b1.Inorder();

        }
        public static void graph()
        {
            LinkGraph g1 = new LinkGraph(5);
           // GRAPH g1 = new GRAPH(5);
            g1.AddEdge(0, 1);
            g1.AddEdge(0, 2);
            g1.AddEdge(1, 3);
            g1.AddEdge(2, 4);

           // g1.AddEdge(1, 4);
            g1.BFS(0);
            //g1.DFS(0);
        }
        public static void spath()
        {
            Dijskrata d1 = new Dijskrata(4);
            d1.AddEdge(0, 1, 5);
            d1.AddEdge(0, 2, 2);
            d1.AddEdge(2, 3, 6);
            d1.AddEdge(3, 0, -1);
            d1.AddEdge(1, 3, 4);
            d1.AddEdge(1, 0, 3);
            d1.BellemenFord(0);
            
        }
        public static void pattern()
        {
            String_pattern_Matching s1 = new String_pattern_Matching();
            s1.Rabin_Karp("usman university", "university");
        }
    }
}
