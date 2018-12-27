using System;
using SolutionLib.Tools;

namespace SolutionLib.Questions {
    public class Question7 : IQuestion {
        /*
        Given a 32-bit signed integer, reverse digits of an integer.

        Example 1:

        Input: 123
        Output: 321

        Example 2:

        Input: -123
        Output: -321

        Example 3:

        Input: 120
        Output: 21

        Note:
        Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−2 square 31,  2 square 31 − 1]. 
        For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
         */
        public void Run () {
            WatchDog.ShowPerformance (ReverseNumber, -900001);
        }

        /// <summary>
        /// Question7 Solution
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int ReverseNumber (int number) {
            int rev = 0;
            while (number != 0) {
                int pop = number % 10;
                number /= 10;
                if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7)) return 0;
                if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8)) return 0;
                rev = rev * 10 + pop;
            }
            return rev;
        }
    }
}