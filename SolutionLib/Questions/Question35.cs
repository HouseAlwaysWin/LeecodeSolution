using SolutionLib.Tools;

namespace SolutionLib.Questions {
    public class Question35 : IQuestion {
        /*
        Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

        You may assume no duplicates in the array.

        Example 1:

        Input: [1,3,5,6], 5
        Output: 2
        Example 2:

        Input: [1,3,5,6], 2
        Output: 1
        Example 3:

        Input: [1,3,5,6], 7
        Output: 4
        Example 4:

        Input: [1,3,5,6], 0
        Output: 0
        */
        public void Run () {
            int[] nums = { 2, 5 };
            int target = 1;
            System.Console.WriteLine ("V1:");
            WatchDog.ShowPerformance (SearchInsert, nums, target);
        }
        public int SearchInsert (int[] nums, int target) {
            for (int i = 0; i < nums.Length; i++) {
                if (target < nums[i]) return 0;
                else if (nums[i] == target) {
                    return i;
                } else if (i < nums.Length - 1) {
                    if (nums[i] < target && nums[i + 1] > target) {
                        return i + 1;
                    }
                } else {
                    return nums.Length;
                }
            }
            return 0;
        }
    }
}