using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class HeapSort
    {
        static public int[] Sort(int[] a)
        {
            if (a.Length > 0)
            {
                return HalfSort(a, 0, a.Length - 1);
            }

            return a;
        }

        static private int[] HalfSort(int[] a, int left, int right)
        {
            if (right > left)
            {
                int middle = (left + right) / 2;

                int[] leftArray = HalfSort(a, left, middle); //排序左边
                int[] rightArray = HalfSort(a, middle + 1, right);  //排序右边

                int[] newArray = new int[leftArray.Length + rightArray.Length];
                int i = 0, j = 0, k = 0;
                while (k < newArray.Length)   //将两个有序数组合并成一个有序数组
                {
                    if (j == rightArray.Length || (i < leftArray.Length && leftArray[i] < rightArray[j]))
                    {
                        newArray[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        newArray[k] = rightArray[j];
                        j++;
                    }
                    k++;
                }
                return newArray;
            }
            else
            {
                int[] newArray = { a[left] }; //不会有left > right的情况出现
                return newArray;
            }
        }
    }
}
