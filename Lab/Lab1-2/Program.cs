﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab1_2
{
    class BubbleSortFunction
    {
        static int[] input()
            {
            int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1};
            return input;
            }
        static void
            process(int[]x)
                {
                bool flag = true;
                     while (flag)
                    {
                         flag = false;
                               for (int i = 0; i != x.Length - 1; i++)
                                {
                                      if (x[i] > x[i + 1])
                                        {
                                         int temp = x[i];
                                         x[i] = x[i + 1];
                                         x[i + 1] = temp;
                                         flag = true;
                                        }
                                }
                    }
                }
        static void
            output(int[]x)
                 {
                  for (int i = 0; i != x.Length; i++)
                     {
                     Console.Write(x[i]);
                     Console.Write(" ");
                     }
                 }
       static void
            Main(string[] args)
                 {
                 int[] x = input();
                 process(x);
                 output(x);
                 Console.ReadKey();
                 }
         }
}
    
