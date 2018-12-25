using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SolutionLib.Questions {
    public class Question1 {
        /*
        Question1:
        Given an array of integers, return indices of the two numbers such that they add up to a specific target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        Example:

        Given nums = [2, 7, 11, 15], target = 9,

        Because nums[0] + nums[1] = 2 + 7 = 9,
        return [0, 1].

         */
         /// <summary>
         /// Question1 Solution
         /// </summary>
         /// <param name="nums"></param>
         /// <param name="target"></param>
         /// <returns></returns>
        public int[] TwoSum (int[] nums, int target) {
            Dictionary<int, int> dict = new Dictionary<int, int> ();
            for (int i = 0; i < nums.Length; i++) {
                int complement = target - nums[i];
                if (dict.ContainsKey (complement)) {
                    return new int[] { dict[complement], i };
                }
                if (!dict.ContainsKey (nums[i])) {
                    dict.Add (nums[i], i);
                }
            }
            return new int[] { };
        }

    }
}