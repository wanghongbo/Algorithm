
/*
Given a 32-bit signed integer, reverse digits of an integer.

Example 1:

Input: 123
Output: 321
Example 2:

Input: -123
Output: -321
Example 3:

Input: 120
Output: 21
Note:
Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
*/

namespace Algorithm.LeetCode {
    public class ReverseInteger {
        public static int Perform(int x) {
            bool negative = x < 0 ? true : false;
            x = negative ? -x : x;
            int r = 0;
            int p = 0;
            while (x > 0) {
                int c = x % 10;
                r = r * 10 + c;
                if ((r - c) / 10 != p) {    //判断是否溢出
                    return 0;
                }
                p = r;
                x = x / 10;
            }
            return negative ? -r : r;
        }
    }
}
