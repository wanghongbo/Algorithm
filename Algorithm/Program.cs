using System;

namespace Algorithm {
    class Program {
        static void Main(string[] args) {
            //int[] a = { 11, 17, 3, 1, 12, 18, 7, 20, 13, 10, 9, 2, 19, 4, 14, 6, 5, 15, 8, 16 };
            int[] a = { 6, 3, 7, 4, 2, 5, 1, 8 };

            int[] r = HeapSort.Sort(a);

            for (int i = 0; i < r.Length; i++) {
                Console.Out.WriteLine(r[i]);
            }
        }
    }
}
