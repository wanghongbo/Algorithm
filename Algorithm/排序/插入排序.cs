using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm {
    public class InsertionSort {
        static public int[] Sort(int[] a) {

            for (int i = 0; i < a.Length; i++) {
                int temp = a[i];
                int j = i;
                while (j - 1 >= 0 && temp < a[j - 1]) {
                    a[j] = a[j - 1];
                    j--;
                }
                if (j != i) {
                    a[j] = temp;
                }

            }

            return a;
        }
    }
}
