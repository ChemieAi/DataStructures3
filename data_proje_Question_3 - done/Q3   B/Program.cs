using System;
using System.Collections.Generic;

namespace minimum_spanning_tree
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
            bool[] gezildiMi = new bool[7];

            for (int i = 1; i < 7; i++)
            {
                gezildiMi[i] = false;
            }

            gezildiMi[0] = true;
            List<int> gezilenVertexler = new List<int>();
            gezilenVertexler.Add(0);
            for (int m = 0; m < 7; m++)
            {
                int enKısa = 1000;
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (gezildiMi[i] == true && gezildiMi[j] == false)
                        {
                            if (enKısa > çizgeler[i, j])
                            {
                                enKısa = çizgeler[i, j];
                            }
                        }
                    }
                }
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (gezildiMi[i] == true && gezildiMi[j] == false)
                        {
                            if (enKısa == çizgeler[i, j])
                            {
                                gezilenVertexler.Add(j);
                                gezildiMi[j] = true;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < 7; i++)
            {
                Console.Write(gezilenVertexler[i] + ", ");
            }
        }

    }
}