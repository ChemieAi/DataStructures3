using System;

namespace Dijktras_shortest_path
{
    class Program
    {
        static int inf = 1000;
        static void Main(string[] args)
        {

            int[,] cost = new int[5, 5] {
              { 1000,    5,    3, 1000,    2},
              { 1000, 1000,    2,    6, 1000},
              { 1000,    1, 1000,    2, 1000},
              { 1000, 1000, 1000, 1000, 1000},
              { 1000,    6,   10,    4,    8}  };
            int[] minDistance = new int[5];
            int sehirSayısı = 5;
            MinDistance(sehirSayısı, cost, minDistance);
            for (int i = 0; i < minDistance.Length; ++i)
            {
                Console.Write(minDistance[i]);
                if (i != (minDistance.Length - 1))
                {
                    Console.Write(", ");
                }
            }
        }


        public static void MinDistance(int N, int[,] cost, int[] D)
        {
            int w, v, min;

            bool[] visited = new bool[N];

            D[0] = 0;
            for (v = 1; v < N; v++)
            {
                visited[v] = false;
                D[v] = cost[0, v];
            }
            for (int i = 1; i < N; ++i)
            {
                min = inf;
                for (w = 1; w < N; w++)
                    if (!visited[w])
                        if (D[w] < min)
                        {
                            v = w;
                            min = D[w];
                        }
                visited[v] = true;

                for (w = 1; w < N; w++)
                    if (!visited[w])
                        if (min + cost[v, w] < D[w])
                            D[w] = min + cost[v, w];
            }

        }

    }
}
