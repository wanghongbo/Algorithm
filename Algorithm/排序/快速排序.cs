using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class QuickSort
    {
        static public int[] Sort(int[] a)
        {
            Sort(a, 0, a.Length - 1);
            return a;
        }

        static private void Sort(int[] a, int left, int right)
        {
            if (left >= right)
                return;
            int j = Partition(a, left, right);
            Sort(a, left, j - 1);
            Sort(a, j + 1, right);
        }

        //Partition函数的作用是返回一个索引j，并使得数组a中索引j左边的元素都小于等于a[j]，索引j右边的元素都大于等于a[j]
        static private int Partition(int[] a, int left, int right)
        {
            if (left == right)
                return left;
            int x = a[left];
            int i = left, k = right, t = 0;
            while (i < k)
            {
                if (t % 2 == 0)
                {
                    while (k > i)
                    {
                        if (a[k] <= x)
                        {
                            a[i] = a[k];
                            i++;
                            break;
                        }
                        k--;
                    }
                }
                else
                {
                    while (i < k)
                    {
                        if (a[i] >= x)
                        {
                            a[k] = a[i];
                            k--;
                            break;
                        }
                        i++;
                    }
                }
                t++;
            }
            a[i] = x;
            return i;
        }
    }
}
