
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

namespace Algorithm.LeetCode {
    public class FindMedianSortedArrays {
        public static double Perform(int[] nums1, int[] nums2) {
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
