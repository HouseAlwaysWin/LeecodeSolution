using System;
using System.Collections.Generic;
using System.Diagnostics;
using SolutionLib.Questions;
using SolutionLib.Tools;

namespace SolutionLib.Questions1 {
    public class Question1 : IQuestion {
        /*
        Question1:
        Given an array of integers, return indices of the two numbers such that they add up to a specific target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        Example:

        Given nums = [2, 7, 11, 15], target = 9,

        Because nums[0] + nums[1] = 2 + 7 = 9,
        return [0, 1].

         */
        public void Run () {
            int[] nums = { 1, 200, 3, 4 };
            int target = 203;
            Question1 q1 = new Question1 ();
            WatchDog.ShowPerformance (q1.TwoSum, nums, target);
        }
        /// <summary>
        /// Question1 Solution
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private int[] TwoSum (int[] nums, int target) {
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