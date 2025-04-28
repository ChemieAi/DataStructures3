using System;
using System.Collections.Generic;

namespace Breadth_First_Traverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] çizgeler = new int[7, 7] {
              { 1000,    5,    4, 1000,    23, 95,15},
              { 5   , 1000,    22,    6, 1000,   7,3},
              { 4   ,    22, 1000,    2, 1000, 100,9},
              { 1000,    6,    2, 1000, 1000,1000,1000},
              { 23   , 1000, 1000,  1000, 1000,1000,1000},
              { 95 ,    7,  100,  1000, 1000,1000,1 },
              { 15  ,    3,    9,  1000, 1000,1,1000} };
            BFS(çizgeler, 0);
        }

        public static void BFS(int[,] uzaklıklarMatrisi, int başlancakNode)
        {

            List<int> stackim = new List<int>();
            bool[] gezildiMi = new bool[7];
            stackim.Add(başlancakNode);
            gezildiMi[başlancakNode] = true;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (uzaklıklarMatrisi[stackim[i], j] < 1000 && gezildiMi[j] == false)
                    {
                        stackim.Add(j);
                        gezildiMi[j] = true;

                    }
                }
            }
            for (int i = 0; i < stackim.Count; i++)
            {
                Console.Write(stackim[i]);
                if (i != stackim.Count - 1)
                {
                    Console.Write(", ");
                }
            }


        }
    }
}
