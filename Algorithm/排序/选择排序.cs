﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class SelectorSort
    {
        static public int[] Sort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int minIndex = i;
                int min = a[i];
                for (int j = i; j < a.Length; j++)
                {
                    if (a[j] < min)
                    {
                        min = a[j];
                        minIndex = j;
                    }
                }
                int temp = a[i];
                a[i] = a[minIndex];
                a[minIndex] = temp;
            }
            return a;
        }
    }
}
