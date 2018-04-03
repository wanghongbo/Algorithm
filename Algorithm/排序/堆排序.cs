using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm {
    public class HeapSort {
        public static int[] Sort(int[] a) {
            int N = a.Length;
            int k = N / 2 - 1;    //k表示具有子节点的最大节点（这个最大指的是在数组中的位置最大），由(i + 1) * 2 - 1 <= N - 1推导出i <= N / 2 - 1
            for (int i = k; i >= 0; i--) {
                Sink(a, i, N - 1);
            }
            while (N > 1) {
                Exch(a, 0, N - 1);
                Sink(a, 0, N - 2);
                N--;
            }

            return a;
        }

        //与优先队列的数组不同，此数组索引由0开始
        private static void Sink(int[] a, int lo, int hi) {
            while ((lo + 1) * 2 - 1 <= hi) {
                int j = (lo + 1) * 2 - 1;
                if (j < hi && a[j] <= a[j + 1]) {
                    j++;
                }
                if (a[j] <= a[lo]) {
                    break;
                }
                Exch(a, lo, j);
                lo = j;
            }
        }

        private static void Exch(int[] a, int i, int j) {
            int t = a[i];
            a[i] = a[j];
            a[j] = t;
        }
    }
}
