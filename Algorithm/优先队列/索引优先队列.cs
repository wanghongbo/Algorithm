using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.优先队列 {
    public class IndexMinPQ {
        private int N;  //PQ中的元素数量
        private int[] pq;   //索引二叉堆，由1开始
        private int[] qp;   //逆序：qp[pq[i]] = pq[qp[i]] = i
        private int[] keys; //有优先级之分的元素

        public IndexMinPQ(int maxN) {
            keys = new int[maxN + 1];
            pq = new int[maxN + 1];
            qp = new int[maxN + 1];
            for (int i = 0; i <= maxN; i++) {
                qp[i] = -1;
            }
        }

        public bool IsEmpty() {
            return N == 0;
        }

        public bool Contains(int k) {
            return qp[k] != -1;
        }

        //在索引为k的位置插入元素key
        public void Insert(int k, int key) {
            N++;
            qp[k] = N;
            pq[N] = k;
            keys[k] = key;
            Swim(N);
        }

        public int Min() {
            return keys[pq[1]];
        }

        //删除最小的元素并且返回其索引
        public int DelMin() {
            int indexOfMin = pq[1];
            Exch(1, N--);
            Sink(1);
            //keys[pq[N + 1]] = null;
            qp[pq[N + 1]] = -1;
            return indexOfMin;
        }

        //最小元素的索引
        public int MinIndex() {
            return pq[1];
        }

        //把索引为k的元素换成元素key
        public void Change(int k, int key) {
            keys[k] = key;
            Swim(qp[k]);
            Sink(qp[k]);
        }

        //删除索引为k的元素
        public void Delete(int k) {
            int index = qp[k];
            Exch(index, N--);
            Swim(index);
            Sink(index);
            //keys[k] = null;
            qp[k] = -1;
        }
        
        private bool Greater(int i, int j) {
            return keys[pq[i]].CompareTo(keys[pq[j]]) > 0;
        }

        private void Exch(int i, int j) {
            qp[pq[i]] = j;
            qp[pq[j]] = i;

            int t = pq[i];
            pq[i] = pq[j];
            pq[j] = t;
        }

        private void Swim(int k) {
            while (k > 1 && Greater(k / 2, k)) {
                Exch(k, k / 2);
                k = k / 2;
            }
        }

        private void Sink(int k) {
            while (2 * k <= N) {
                int j = 2 * k;
                if (j < N && Greater(j, j + 1)) {
                    j++;
                }
                if (!Greater(k, j)) {
                    break;
                }
                Exch(k, j);
                k = j;
            }
        }
    }
}
