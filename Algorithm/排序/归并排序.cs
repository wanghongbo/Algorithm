using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class MergeSort
    {
        static private int[] b;

        static public int[] Sort(int[] a)
        {
            b = new int[a.Length];
            Sort(a, 0, a.Length - 1);
            return a;
        }

        static private void Sort(int[] a, int left, int right)
        {
            if (right <= left)
            {
                return;
            }
            else if (right > left)
            {
                int middle = (left + right) / 2;

                Sort(a, left, middle); //排序左边
                Sort(a, middle + 1, right);  //排序右边

                //先将数组复制到b
                for (int k = left; k <= right; k++)
                {
                    b[k] = a[k];
                }
                //将数组b归并回a
                int i = left, j = middle + 1;
                for (int k = left; k <= right; k++)
                {
                    if (i > middle)
                    {
                        a[k] = b[j++];
                    }
                    else if (j > right)
                    {
                        a[k] = b[i++];
                    }
                    else if (b[i] > b[j])
                    {
                        a[k] = b[j++];
                    }
                    else
                    {
                        a[k] = b[i++];
                    }
                }
            }
        }
    }
}
