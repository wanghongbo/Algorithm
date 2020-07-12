using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.剑指Offer {
    public class QueenCombination {
        static int count = 0;

        void Test() {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 };
            Perform(arr, 0);
            count = 0;
            System.Console.WriteLine(count);
        }

        public static void Perform(int[] arr, int start) {
            if (start == arr.Length) {
                if (Check(arr)) {
                    count++;
                }
                return;
            }
            for (int i = start; i < arr.Length; i++) {
                int tmp = arr[start];
                arr[start] = arr[i];
                arr[i] = tmp;

                Perform(arr, start + 1);

                tmp = arr[start];
                arr[start] = arr[i];
                arr[i] = tmp;
            }
        }

        /// <summary>
        /// 检查是否有两个皇后在对角线上
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>有返回false</returns>
        static bool Check(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                for (int j = i + 1; j < arr.Length; j++) {
                    if (i - j == arr[i] - arr[j] || j - i == arr[i] - arr[j]) {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
