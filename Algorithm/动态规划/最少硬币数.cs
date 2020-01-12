
/*
有面值分别为1，3，5的三种硬币若干，需要凑成11元最少需要多少硬币，凑成n元最少需要多少硬币？
*/

namespace Algorithm.动态规划 {
    public class  MinCountOfCoins{
        static int[] v = { 1, 3, 5 };

        public static int Perform(int n) {
            int[] a = new int[n + 1];
            a[0] = 0;
            for (int i = 1; i < n + 1; i++) {
                a[i] = a[i - 1] + 1;
                for (int j = 0; j < v.Length; j++) {
                    if (i >= v[j]) {
                        if (a[i - v[j]] + 1 < a[i]) {
                            a[i] = a[i - v[j]] + 1;
                        };
                    }
                }
            }
            return a[n];
        }
    }
}
