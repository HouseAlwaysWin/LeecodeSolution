using System;
using SolutionLib.Tools;

namespace SolutionLib.Questions283 {
    public class Question283 : IQuestion {
        /*
        Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        Example:

        Input: [0,1,0,3,12]
        Output: [1,3,12,0,0]
        Note:

        You must do this in-place without making a copy of the array.
        Minimize the total number of operations.
         */
        public void Run () {
            int[] nums = new int[] { 1, 0 };
            WatchDog.ShowPerformance (MoveZeroes, nums);
        }

        public void MoveZeroes (int[] nums) {
            int count = 0;

            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] != 0) {
                    nums[count++] = nums[i];
                    if (i != count) {
                        nums[i] = 0;
                    }
                }
            }
        }
    }
}