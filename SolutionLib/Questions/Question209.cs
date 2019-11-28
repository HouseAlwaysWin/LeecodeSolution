using System;
using System.Collections.Generic;
using SolutionLib.Tools;

namespace SolutionLib.Questions209 {

    public class Question209 : IQuestion {
        /*
        Given an array of n positive integers and a positive integer s, 
        find the minimal length of a contiguous subarray of which the sum ≥ s. If there isn't one, return 0 instead.

        Example: 

        Input: s = 7, nums = [2,3,1,2,4,3]
        Output: 2
        Explanation: the subarray [4,3] has the minimal length under the problem constraint.
        Follow up:
        If you have figured out the O(n) solution, try coding another solution of which the time complexity is O(n log n). 
         */
        public void Run () {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            WatchDog.ShowPerformance<int, int[], int> (MinSubArrayLenV1, 15, nums);
        }

        /// <summary>
        /// Brute Force
        /// </summary>
        /// <param name="s"></param>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinSubArrayLenV1 (int s, int[] nums) {
            int min = nums.Length;
            bool hasSeq = false;

            for (int i = 0; i < nums.Length; i++) {
                int count = 1;
                int sum = 0;
                for (int j = i; j < nums.Length; j++) {
                    sum = sum + nums[j];
                    if (sum >= s) {
                        if (min >= count) {
                            min = count;
                            count = 1;
                            sum = 0;
                            hasSeq = true;
                        }
                    } else {
                        count++;
                    }
                }
            }
            if (!hasSeq) {
                min = 0;
            }
            return min;
        }
        public int MinSubArrayLenV2 (int s, int[] nums) {
            return 0;
        }
    }
}