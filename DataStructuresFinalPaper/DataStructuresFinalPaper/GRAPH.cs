using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalPaper
{
    class GRAPH
    {
        int[,] adjacencymatrix;
        public GRAPH(int numberofmatrix)
        {
            adjacencymatrix = new int[numberofmatrix, numberofmatrix];
        }
        public void AddEdge(int source, int destinatin)
        {
            adjacencymatrix[source, destinatin] = 1;
            adjacencymatrix[destinatin, source] = 1;
        }
        public int[] GetNeighbours(int source)
        {
            List<int> l1 = new List<int>();
            for (int i = 0; i < adjacencymatrix.GetLength(0); i++)
            {
                if (adjacencymatrix[source, i] > 0)
                    l1.Add(i);
            }
            return l1.ToArray();
        }
        public void DFS(int source)
        {
            Stack<int> s1 = new Stack<int>();
            s1.Push(source);
            List<int> l1 = new List<int>();
            l1.Add(source);
            while (s1.Count != 0)
            {
                int[] neighbours = GetNeighbours(s1.Pop());
                foreach (int i in neighbours)
                {
                    if (!l1.Contains(i))
                    {
                        l1.Add(i);
                        s1.Push(i);
                        Console.WriteLine(i);
                    }
                }
            }
        }
        public void BFS(int source)
        {
            Queue<int> q1 = new Queue<int>();
            q1.Enqueue(source);
            List<int> l1 = new List<int>();
            l1.Add(source);
            while (q1.Count != 0)
            {
                int[] neighbours = GetNeighbours(q1.Dequeue());
                foreach (int i in neighbours)
                {
                    if (!l1.Contains(i))
                    {
                        Console.WriteLine(i);
                        l1.Add(i);
                        q1.Enqueue(i);
                    }
                }
            }
        }
    }
}
