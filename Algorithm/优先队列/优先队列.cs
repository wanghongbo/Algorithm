using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm {
    public class MaxPQ {
        private int[] pq;
        private int N = 0;

        public MaxPQ(int maxN) {
            pq = new int[maxN + 1];
        }

        public bool IsEmpty() {
            return N == 0;
        }

        public int Size() {
            return N;
        }

        public void Insert(int v) {
            pq[++N] = v;
            Swim(N);
        }

        public int DelMax() {
            int max = pq[1];
            Exch(1, N--);
            //pq[N + 1] = null;
            Sink(1);
            return max;
        }

        private bool Less(int i, int j) {
            return pq[i].CompareTo(pq[j]) < 0;
        }

        private void Exch(int i, int j) {
            int t = pq[i];
            pq[i] = pq[j];
            pq[j] = t;
        }

        private void Swim(int k) {
            while (k > 1 && Less(k / 2, k)) {
                Exch(k, k / 2);
                k = k / 2;
            }
        }

        private void Sink(int k) {
            while (2 * k <= N) {
                int j = 2 * k;
                if (j < N && Less(j, j + 1)) {
                    j++;
                }
                if (!Less(k, j)) {
                    break;
                }
                Exch(k, j);
                k = j;
            }
        }
    }

}
