using System.Collections.Generic;
using SolutionLib.Tools;

namespace SolutionLib.Questions167 {
    public class Question167 : IQuestion {
        /*
        Given an array of integers that is already sorted in ascending order, 
        find two numbers such that they add up to a specific target number.

        The function twoSum should return indices of the two numbers such that they add up to the target, 
        where index1 must be less than index2.

        Note:

        Your returned answers (both index1 and index2) are not zero-based.
        You may assume that each input would have exactly one solution and you may not use the same element twice.
        Example:

        Input: numbers = [2,7,11,15], target = 9
        Output: [1,2]
        Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.
         */
        public void Run () {
            int[] nums = new int[] { 2, 7, 11, 15 };
            WatchDog.ShowPerformance (TwoSum, nums, 9);
        }

        public int[] TwoSum (int[] numbers, int target) {
            Dictionary<int, int> dict = new Dictionary<int, int> ();
            for (int i = 0; i < numbers.Length; i++) {
                int complement = target - numbers[i];
                if (dict.ContainsKey (complement)) {
                    return new int[] { dict[complement], i + 1 };
                }

                if (!dict.ContainsKey (numbers[i])) {
                    dict.Add (numbers[i], i + 1);
                }
            }
            return new int[] { };
        }

    }
}