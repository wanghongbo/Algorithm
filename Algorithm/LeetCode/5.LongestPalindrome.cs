
/*
Given a string s, find the longest palindromic substring in s.You may assume that the maximum length of s is 1000.

Example 1:

Input: "babad"
Output: "bab"
Note: "aba" is also a valid answer.
Example 2:

Input: "cbbd"
Output: "bb"
*/

namespace Algorithm.LeetCode {
    public class LongestPalindrome {

        //动态规划
        public static string Perform(string s) {
            if (string.IsNullOrEmpty(s)) {
                return "";
            }
            int n = s.Length;
            bool[,] aux = new bool[n, n];   //aux[i][j]表示i到j的字符串是否为回文
            int left = 0;
            int right = 0;
            for (int i = n - 1; i >= 0; i--) {
                for (int j = i; j < n; j++) {
                    if (i == j) {
                        aux[i, j] = true;
                    } else if (j - i == 1) {
                        aux[i, j] = s[i] == s[j];
                    } else {
                        aux[i, j] = aux[i + 1, j - 1] && s[i] == s[j];
                    }
                    if (aux[i, j] && (j - i >= right - left)) {
                        left = i;
                        right = j;
                    }
                }
            }
            return s.Substring(left, right - left + 1);
        }

        //暴力法
        public static string Perform2(string s) {
            int left = 0;
            int length = 0;
            for (int i = 0; i < s.Length; i++) {
                if (s.Length - i < length) {
                    return s.Substring(left, length);
                }
                for (int j = s.Length - 1; j >= i; j--) {
                    if (j - i + 1 < length) {
                        break;
                    }
                    string sub = s.Substring(i, j - i + 1);
                    if (CheckPalindromic(sub) && sub.Length > length) {
                        left = i;
                        length = j - i + 1;
                    }
                }
            }
            return s.Substring(left, length);
        }

        private static bool CheckPalindromic(string s) {
            int i = 0;
            int j = s.Length - 1;
            while (j >= i) {
                if (s[i++] != s[j--]) {
                    return false;
                }
            }
            return true;
        }
    }
}
