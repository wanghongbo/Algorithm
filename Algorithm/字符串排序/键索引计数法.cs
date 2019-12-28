using System;

namespace Algorithm {
    public class KeyIndexedCountingSort {
        /// <summary>
        /// 键索引计数法排序
        /// </summary>
        /// <param name="a">待排序数组</param>
        /// <param name="R">字符总数</param>
        public static void Sort(Node[] a, int R) {
            int N = a.Length;
            // 统计频率
            int[] count = new int[R + 1];
            for (int i = 0; i < N; i++) {
                int key = a[i].Key;
                count[key + 1]++;
            }
            // 将频率转换为索引
            for (int i = 1; i < count.Length; i++) {
                count[i] = count[i - 1] + count[i];
            }
            // 数据分类
            Node[] aux = new Node[N];
            for (int i = 0; i < N; i++) {
                int key = a[i].Key;
                int index = count[key]++;
                aux[index] = a[i];
            }
            // 回写
            for (int i = 0; i < N; i++) {
                a[i] = aux[i];
            }
        }
    }

    public struct Node: IEquatable<Node>  {
        public string Name { get; private set; }
        public int Key { get; private set; }

        public Node(string name, int key) {
            this.Key = key;
            this.Name = name;
        }

        public bool Equals(Node other) {
            return this.Name == other.Name && this.Key == other.Key;
        }
    }
}
