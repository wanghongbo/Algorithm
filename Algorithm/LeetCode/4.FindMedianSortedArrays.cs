
/*
There are two sorted arrays nums1 and nums2 of size m and n respectively.

Find the median of the two sorted arrays.The overall run time complexity should be O(log (m+n)).

You may assume nums1 and nums2 cannot be both empty.

Example 1:

nums1 = [1, 3]
nums2 = [2]

The median is 2.0
Example 2:

nums1 = [1, 2]
nums2 = [3, 4]

The median is (2 + 3)/2 = 2.5
*/

using System;

namespace Algorithm.LeetCode {
    public class FindMedianSortedArrays {
        /// <summary>
        /// 方法1，时间复杂度O(m + n)
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static double Perform1(int[] nums1, int[] nums2) {
            if (nums1.Length > nums2.Length) {
                return Perform1(nums2, nums1);
            }
            return BinarySearch(nums1, 0, nums1.Length, nums2);
        }

        private static double BinarySearch(int[] nums1, int left, int right, int[] nums2) {
            int m = nums1.Length;
            int n = nums2.Length;
            int i = (right - left + 1) / 2 + left;
            int j = (m + n + 1) / 2 - i;
            if (i < m && nums1[i] < nums2[j - 1]) {
                return BinarySearch(nums1, i, right, nums2);    //向右查找
            } else if (i > 0 && nums1[i - 1] > nums2[j]) {
                return BinarySearch(nums1, left, i - 1, nums2); //向左查找
            } else {
                if ((m + n) % 2 == 0) {
                    return (MaxLeft(nums1, i - 1, nums2, j - 1) + MinRight(nums1, i, nums2, j) ) / 2.0;
                } else {
                    return MaxLeft(nums1, i - 1, nums2, j - 1);
                }
            }
        }

        private static int MaxLeft(int[] nums1, int i, int[] nums2, int j) {
            if (i < 0) {
                return nums2[j];
            } else if (j < 0) {
                return nums1[i];
            } else {
                return Math.Max(nums1[i], nums2[j]);
            }
        }

        private static int MinRight(int[] nums1, int i, int[] nums2, int j) {
            if (i >= nums1.Length) {
                return nums2[j];
            } else if (j >= nums2.Length) {
                return nums1[i];
            } else {
                return Math.Min(nums1[i], nums2[j]);
            }
        }

        /// <summary>
        /// 方法2，时间复杂度为O((m + n) / 2)，达不到O(lg(m + n))
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static double Perform2(int[] nums1, int[] nums2) {
            int length = (nums1.Length + nums2.Length) / 2 + 1;
            int[] aux = new int[length];
            int i = 0;
            int j = 0;
            int k = 0;
            while (k < length) {
                if (i < nums1.Length && j < nums2.Length) {
                    if (nums1[i] < nums2[j]) {
                        aux[k] = nums1[i];
                        i++;
                    } else {
                        aux[k] = nums2[j];
                        j++;
                    }
                } else if (i < nums1.Length) {    //j超出
                    aux[k] = nums1[i];
                    i++;
                } else if (j < nums2.Length) {    //i超出
                    aux[k] = nums2[j];
                    j++;
                } else {    //i,j同时超出时，k肯定已经超出，循环已经结束，不用考虑此种情况
                }
                k++;
            }
            if ((nums1.Length + nums2.Length) % 2 == 0) {
                return (aux[length - 1] + aux[length - 2]) / 2.0;
            } else {
                return aux[length - 1];
            }
        }
    }
}
