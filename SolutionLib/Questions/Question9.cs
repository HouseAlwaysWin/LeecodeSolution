using System;
using SolutionLib.Tools;

namespace SolutionLib.Questions {
    public class Question9 : IQuestion {
        /*
        Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

        Example 1:

        Input: 121
        Output: true
        Example 2:

        Input: -121
        Output: false
        Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
        Example 3:

        Input: 10
        Output: false
        Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

        Follow up:
        Coud you solve it without converting the integer to a string?
         */
        public void Run () {
            WatchDog.ShowPerformance (IsPalindrome, int.MaxValue);
        }

        public bool IsPalindrome (int number) {
            int temp = number;
            int rev = 0;
            while (number != 0) {
                int pop = number % 10;
                number /= 10;
                if (number > int.MaxValue / 10 || (number == int.MaxValue && pop > 7)) return false;
                if (number < int.MinValue / 10 || (number == int.MinValue && pop < -8)) return false;
                rev = rev * 10 + pop;
            }
            if (Math.Abs (rev) == temp) {
                return true;
            }
            return false;
        }
    }
}