
namespace Algorithm.排序 {
    public class QuickSort {
        static public int[] Sort(int[] a) {
            //Sort(a, 0, a.Length - 1);
            Sort3Way(a, 0, a.Length - 1);
            return a;
        }

        //三向切分的快速排序
        static private void Sort3Way(int[] a, int lo, int hi) {
            if (lo >= hi) {
                return;
            }
            int lt = lo, i = lo + 1, gt = hi;
            int v = a[lo];
            while (i <= gt) {
                int cmp = a[i].CompareTo(v);
                if (cmp < 0) {
                    Swap(a, lt, i);
                    lt++;
                    i++;
                } else if (cmp > 0) {
                    Swap(a, i, gt);
                    gt--;
                } else {
                    i++;
                }
            }
            Sort3Way(a, lo, lt - 1);
            Sort3Way(a, gt + 1, hi);
        }

        //普通快速排序
        static private void Sort(int[] a, int left, int right) {
            if (left >= right)
                return;
            //int j = Partition(a, left, right);
            int j = PartitionInBook(a, left, right);
            Sort(a, left, j - 1);
            Sort(a, j + 1, right);
        }

        //Partition函数的作用是返回一个索引j，并使得数组a中索引j左边的元素都小于等于a[j]，索引j右边的元素都大于等于a[j]
        //参考http://blog.csdn.net/morewindows/article/details/6684558
        static private int Partition(int[] a, int left, int right) {
            if (left == right)
                return left;
            int x = a[left];
            int i = left, k = right;
            while (i < k) {
                while (i < k && a[k] > x) {
                    k--;
                }
                if (i < k) {
                    a[i] = a[k];
                }
                while (i < k && a[i] < x) {
                    i++;
                }
                if (i < k) {
                    a[k] = a[i];
                    k--;
                }
            }
            a[i] = x;
            return i;
        }

        //参考《算法》一书中Partition函数的另一种写法
        static private int PartitionInBook(int[] a, int left, int right) {
            int i = left, k = right + 1;
            int x = a[left];
            while (true) {
                while (a[++i] < x) {
                    if (i == right) {
                        break;
                    }
                }
                while (a[--k] > x) {
                    if (k == left) {
                        break;
                    }
                }
                if (i < k) {
                    Swap(a, i, k);
                } else {
                    break;
                }
            }
            Swap(a, left, k);

            return k;
        }

        static private void Swap(int[] a, int i, int j) {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
