
/*
给定一根长度为n的绳子，请把绳子剪成m段（m、n都是整数，n>1并且m>1），每段绳子的长度记为k[0],k[1],…,k[m]。
请问k[0]* k[1] * … *k[m]可能的最大乘积是多少？
例如，当绳子的长度是8时，我们把它剪成长度分别为2、3、3的三段，此时得到的最大乘积是18
*/

namespace Algorithm.动态规划 {
    public class CutRope {
        public static int Perform(int n) {
            if (n < 2) {
                return 0;
            }
            if (n == 2) {
                return 1;
            }
            if (n == 3) {
                return 2;
            }
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;
            for (int k = 3; k <= n; k++) {
                int max = k;
                for (int i = 1; i <= k / 2; i++) {
                    int temp = dp[i] * dp[k - i];
                    if (temp > max) {
                        max = temp;
                    }
                }
                dp[k] = max;
            }
            return dp[n];
        }
    }
}
