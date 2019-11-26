using SolutionLib.Tools;

namespace SolutionLib.Questions485 {
    public class Question485 : IQuestion {
        /*
        Given a binary array, find the maximum number of consecutive 1s in this array.

        Example 1:
        Input: [1,1,0,1,1,1]
        Output: 3
        Explanation: The first two digits or the last three digits are consecutive 1s.
            The maximum number of consecutive 1s is 3.
        Note:

        The input array will only contain 0 and 1.
        The length of input array is a positive integer and will not exceed 10,000
         */
        public void Run () {
            int[] nums = new int[] { 1, 1, 0, 1, 1, 1 };
            WatchDog.ShowPerformance (FindMaxConsecutiveOnes, nums);
        }

        public int FindMaxConsecutiveOnes (int[] nums) {
            int count = 0;
            int max = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == 1) {
                    count++;
                } else {
                    count = 0;
                }

                if (count >= max) {
                    max = count;
                }
            }
            return max;
        }
    }
}