
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
        public static string Perform(string s) {
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
