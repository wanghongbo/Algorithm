using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.剑指Offer {
    public class Probability {

        void Test() {
            int n = 2;
            double[] probabilities = Perform(n);
        }

        public static double[] Perform(int n) {
            int max = 6 * n;
            int min = n;
            int[] times = new int[6 * n + 1];
            CountTimes(n, n, 0, times);
            double[] probabilities = new double[6 * n + 1];
            double all = System.Math.Pow(6, n);
            for (int i = min; i <= max; i++) {
                probabilities[i] = times[i] / all;
            }
            return probabilities;
        }

        // 方法1，递归
        static void CountTimes(int n, int current, int sum, int[] times) {
            if (current == 0) {
                times[sum]++;
                return;
            }
            for (int i = 1; i <= 6; i++) {
                CountTimes(n, current - 1, sum + i, times);
            }
        }

        // 方法2，动态规划
        public static int[] CountTimes(int n) {
            int[][] aux = { new int[n * 6 + 1], new int[n * 6 + 1] };
            for (int i = 1; i <= 6; i++) {
                aux[0][i] = 1;
            }
            int flag = 1;
            for (int i = 2; i <= n; i++) {
                int min = i;
                int max = i * 6;
                for (int j = min; j <= max; j++) {
                    for (int k = 1; k <= 6; k++) {
                        if (j - k > 0) {
                            aux[flag][j] += aux[1 - flag][j - k];
                        }
                    }
                }
                flag = 1 - flag;
            }
            return aux[1 - flag];
        }
    }
}
