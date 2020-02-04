
/*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
*/

using System.Collections.Generic;

namespace Algorithm.LeetCode {
    public class TwoSum {
        public static int[] Perform(int[] nums, int target) {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) {
                int left = target - nums[i];
                if (dic.ContainsKey(left)) {
                    int[] result = new int[2];
                    result[0] = dic[left];
                    result[1] = i;
                    return result;
                } else {
                    dic[nums[i]] = i;
                }
            }
            return null;
        }
    }
}