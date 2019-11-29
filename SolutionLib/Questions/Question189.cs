using SolutionLib.Tools;

namespace SolutionLib.Questions189 {
    public class Question189 : IQuestion {
        /*
        Given an array, rotate the array to the right by k steps, where k is non-negative.

        Example 1:

        Input: [1,2,3,4,5,6,7] and k = 3

        Output: [5,6,7,1,2,3,4]
        Explanation:
        rotate 1 steps to the right: [7,1,2,3,4,5,6]
        rotate 2 steps to the right: [6,7,1,2,3,4,5]
        rotate 3 steps to the right: [5,6,7,1,2,3,4]
        Example 2:

        Input: [-1,-100,3,99] and k = 2
        Output: [3,99,-1,-100]
        Explanation: 
        rotate 1 steps to the right: [99,-1,-100,3]
        rotate 2 steps to the right: [3,99,-1,-100]
        Note:

        Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.
        Could you do it in-place with O(1) extra space?
         */
        public void Run () {
            int[] nums = new int[] {
                1,
                2,
                3,
                4,
                5,
                6,
                7
            };
            WatchDog.ShowPerformance<int[], int> (RotateV1, nums, 0);
            WatchDog.ShowPerformance<int[], int> (RotateV2, nums, 0);
        }

        public void RotateV1 (int[] nums, int k) {

            int start = nums.Length - (k % nums.Length);
            if (start == 0 || start == nums.Length) {
                return;
            }
            int index = 0;
            int[] copy_nums = new int[nums.Length];

            while (index < nums.Length) {
                if (start > nums.Length - 1) {
                    start = 0;
                }
                copy_nums[index] = nums[start];
                index++;
                start++;
            }

            for (int i = 0; i < nums.Length; i++) {
                nums[i] = copy_nums[i];
            }

        }

        public void RotateV2 (int[] nums, int k) {

            if (nums == null) { return; }

            int idx = 0;
            int key = idx;
            int val = nums[key];

            int rotations = 0;
            while (rotations < nums.Length) {
                int next_key = (key + k) % nums.Length;

                val = nums[next_key];
                key = next_key;

                nums[next_key] = nums[idx];
                nums[idx] = val;

                if (key == idx && idx + 1 != nums.Length) {
                    idx = idx + 1;
                    key = idx;
                    val = nums[key];
                }

                rotations = rotations + 1;
            }

        }
    }
}