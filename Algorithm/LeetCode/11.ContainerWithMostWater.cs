/*
Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate(i, ai). n vertical lines are drawn such that the two endpoints of line i is at(i, ai) and(i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water.

Note: You may not slant the container and n is at least 2.

Example:
Input: [1,8,6,2,5,4,8,3,7]
Output: 49
*/

using System;
namespace Algorithm.LeetCode {
    public class ContainerWithMostWater {

        //双指针
        public static int Perform(int[] height) {
            int i = 0;
            int j = height.Length - 1;
            int max = 0;
            while (i < j) {
                int a = 0;
                if (height[i] < height[j]) {
                    a = height[i] * (j - i);
                    i++;
                } else {
                    a = height[j] * (j - i);
                    j--;
                }
                if (max < a) {
                    max = a;
                }
            }
            return max;
        }

        //暴力法
        public static int Perform2(int[] height) {
            int max = 0;
            for (int i = 0; i < height.Length; i++) {
                for (int j = i + 1; j < height.Length; j++) {
                    int a = j - i;
                    int b = Math.Min(height[i], height[j]);
                    int c = a * b;
                    if (max < c) {
                        max = c;
                    }
                }
            }
            return max;
        }
    }
}
