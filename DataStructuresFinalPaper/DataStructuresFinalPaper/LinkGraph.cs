using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalPaper
{
    class LinkGraph
    {
        LinkedList<int>[] l1;
        public LinkGraph(int numberofnodes)
        {
            l1 = new LinkedList<int>[numberofnodes];
            for (int i = 0; i < l1.Length; i++)
            {
                l1[i] = new LinkedList<int>();
            }
        }
        public void AddEdge(int source, int destination)
        {
           
            l1[source].AddLast(destination);
        }
        public int[] getneightbours(int source)
        {
            return l1[source].ToArray();
        }
        public void BFS(int source)
        {
            
            Queue<int> q1 = new Queue<int>();
            List<int> l1 = new List<int>();
            q1.Enqueue(0);
            l1.Add(0);
            while (q1.Count != 0)
            {
                foreach (int i in getneightbours(q1.Dequeue()))
                {
                    if(!l1.Contains(i))
                    {
                        l1.Add(i);
                        q1.Enqueue(i);
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
