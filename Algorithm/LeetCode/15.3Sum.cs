/*
Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

Note:

The solution set must not contain duplicate triplets.

Example:

Given array nums = [-1, 0, 1, 2, -1, -4],

A solution set is:
[
  [-1, 0, 1],
  [-1, -1, 2]
]
*/

using System;
using System.Collections.Generic;

namespace Algorithm.LeetCode {
    public class ThreeSum {
        public static IList<IList<int>> Perform(int[] nums) {
            IList<IList<int>> lists = new List<IList<int>>();
            Array.Sort(nums);
            int n = nums.Length;
            for (int k = 0; k < n - 2; k++) {
                if (nums[k] > 0) {
                    break;
                }
                if (k > 0 && nums[k] == nums[k - 1]) {
                    continue;
                }
                int i = k + 1;
                int j = n - 1;
                while (i < j) {
                    if (i > k + 1 && nums[i] == nums[i - 1]) {
                        i++;
                        continue;
                    }
                    if (j < n - 1 && nums[j] == nums[j + 1]) {
                        j--;
                        continue;
                    }
                    if (nums[k] + nums[i] + nums[j] < 0) {
                        i++;
                    } else if (nums[k] + nums[i] + nums[j] > 0) {
                        j--;
                    } else {
                        List<int> list = new List<int>() {
                            nums[k],
                            nums[i],
                            nums[j],
                        };
                        lists.Add(list);
                        i++;
                        j--;
                    }
                }
            }
            return lists;
        }
    }
}
