
namespace Algorithm.排序 {
    public class ShellSort {
        static public int[] Sort(int[] a) {
            for (int h = a.Length / 2; h > 0; h = h / 2) {
                SortOnceOptimized(a, h);
            }

            return a;
        }

        static private int[] SortOnce(int[] a, int h) {
            for (int i = 0; i < h; i++) {
                for (int j = 0; i + j * h < a.Length; j++) {
                    int k = i + j * h;
                    int temp = a[k];
                    while (k - h >= 0 && temp < a[k - h]) {
                        a[k] = a[k - h];
                        k -= h;
                    }
                    if (k != i + j * h) {
                        a[k] = temp;
                    }
                }
            }

            return a;
        }

        //优化写法，少一层循环
        static private int[] SortOnceOptimized(int[] a, int h) {
            for (int i = h; i < a.Length; i++) {
                int j = i;
                int temp = a[j];
                while (j - h >= 0 && temp < a[j - h]) {
                    a[j] = a[j - h];
                    j -= h;
                }
                if (j != i) {
                    a[j] = temp;
                }
            }

            return a;
        }
    }
}
