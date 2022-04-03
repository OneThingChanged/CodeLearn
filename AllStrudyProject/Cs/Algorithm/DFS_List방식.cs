using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Algorithm.DFS_List
{
    class Graph
    {
        public Graph(List<int>[] graph) {
            adj2 = graph;
        }

        List<int>[] adj2;

        bool[] visited = new bool[6];

        public void DFS2(int now)
        {
            // 1) now 부터 방문 하고
            Console.WriteLine(now);
            visited[now] = true;

            // 2) now 와 연결된 정점들을 하나씩 확인해서, [ 아직 미 방문 상태라면 ] 방문한다.
            foreach (int next in adj2[now])
            {
                if (visited[next])      // 이미 방문 했으면 스킵
                    continue;
                DFS2(next);
            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<int>[] adj2 = new List<int>[]
    //        {
    //        new List<int>() { 1, 3 },
    //        new List<int>() { 0, 2, 3 },
    //        new List<int>() { 1 },
    //        new List<int>() { 0, 1, 4 },
    //        new List<int>() { 3, 5 },
    //        new List<int>() { 4 },
    //        };



    //        Graph graph = new Graph(adj2);

    //        graph.DFS2(0);  // 0 1 2 3 4 5
    //        Console.ReadLine();
    //    }
    //}
}
