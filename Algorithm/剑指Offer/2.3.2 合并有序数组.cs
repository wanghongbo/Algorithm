
/*
有两个排序的数组A1和A2，内存在A1的末尾有足够的空余空间容纳A2。请写一个函数，把A2的所有数字插入A1中，
并且所有的数字是排序的。 
*/
namespace Algorithm.从后往前遍历 {
    public class MergeSortedArray {
        public static int[] Perform(int[] a, int n, int[] b) {
            int i = n - 1;
            int j = b.Length - 1;
            int k = n + b.Length - 1;
            while (k >= 0) {
                if (i < 0 || (j >= 0 && a[i] < b[j])) {
                    a[k--] = b[j--];
                } else if (j < 0 || (i >= 0 && a[i] >= b[j])) {
                    a[k--] = a[i--];
                }
            }
            return a;
        }
    }
}
