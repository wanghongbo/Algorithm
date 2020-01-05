using System;
using System.Collections.Generic;
using System.Text;

/*
Given a string, find the length of the longest substring without repeating characters.

Example 1:

Input: "abcabcbb"
Output: 3 
Explanation: The answer is "abc", with the length of 3. 
Example 2:

Input: "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3. 
             Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
*/

namespace Algorithm {
    public class LongestSubstring {
        public static int Perform(string s) {
            int m = 0;
            int left = 0;
            int right = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();    //key为字符，value为字符所在数组中的位置
            for (; right < s.Length; right++) {
                char c = s[right];
                if (dic.ContainsKey(c)) {
                    if (right - left > m) {
                        m = right - left;
                    }
                    if (dic[c] + 1 > left) {
                        left = dic[c] + 1;
                    }
                    dic[c] = right;
                } else {
                    dic[c] = right;
                }
            }
            if (right - left > m) {
                m = right - left;
            }
            return m;
        }
    }
}
