using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalPaper
{
    class Dijskrata
    {
        int[,] adjacencymatrix;
        public Dijskrata(int numberofvertex)
        {
            adjacencymatrix = new int[numberofvertex, numberofvertex];
        }
        public void AddEdge(int source, int destination, int weight)
        {
            adjacencymatrix[source, destination] = weight;
        }
        public int[] GetNeighbour(int source)
        {
            List<int> l1 = new List<int>();
            for (int i = 0; i < adjacencymatrix.GetLength(0); i++)
            {
                if (adjacencymatrix[source, i] > 0)
                {
                    l1.Add(i);
                }
            }
            return l1.ToArray();
        }
        public void GetShortestPath(int source)
        {
            vertex[] distance = new vertex[adjacencymatrix.GetLength(0)];
            for (int i = 0; i < distance.Length; i++)
            {
                distance[i] = new vertex(i, Int32.MaxValue);
            }
            distance[source].weight = 0;
            PriorityQueue pq1 = new PriorityQueue();
            foreach (vertex x in distance)
            {
                pq1.Enqueue(x);
            }
            while (pq1.count != 0)
            {
                vertex x = pq1.extractmin();
                int[] neighbours = GetNeighbour(x.id);
                foreach (int i in neighbours)
                {
                    if (distance[i].weight > adjacencymatrix[x.id, i] + x.weight)
                    {
                        distance[i].weight = adjacencymatrix[x.id, i] + x.weight;
                        distance[i].parent = x.id;
                    }
                }

            }
            foreach (vertex v in distance)
            {
                Console.WriteLine(v.parent + ">>> " + v.id + "== " + v.weight);
            }
        }
        public void BellemenFord(int source)
        {
            vertex[] distance = new vertex[adjacencymatrix.GetLength(0)];
            for (int i = 0; i < distance.Length; i++)
            {
                distance[i] = new vertex(i, int.MaxValue);
            }
            distance[source].weight = 0;
            for (int i = 0; i < distance.Length - 1; i++)
            {
                for (int j = 0; j < distance.Length; j++)
                {
                    int[] neighbours = GetNeighbour(j);
                    foreach(int x in neighbours)
                    {
                        if(distance[x].weight>distance[j].weight+adjacencymatrix[j,x])
                        {
                            distance[x].weight = distance[j].weight + adjacencymatrix[j, x];
                            distance[x].parent = j;
                        }
                    }
                }
            }
            bool check = false;
            for(int  i=0;i<distance.Length;i++)
            {
                int[] neighbours = GetNeighbour(i);
                foreach(int x in neighbours)
                {
                    if (distance[x].weight > distance[i].weight + adjacencymatrix[i, x])
                    {
                        check = true;
                    }
                }
            }
            if(check)
            {
                Console.WriteLine("Solution not possible");
            }
            else
            {
                foreach(vertex x in distance)
                {
                    Console.WriteLine(x.parent+">>>> "+x.id+"== "+x.weight);
                }
            }
        }
    }
    class vertex
    {
        public int id;
        public long weight;
        public int parent;
        public vertex(int id, int weight)
        {
            parent = -1;
            this.weight = weight;
            this.id = id;
        }
    }
}
