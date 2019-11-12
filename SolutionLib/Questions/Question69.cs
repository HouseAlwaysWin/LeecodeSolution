using System;
using SolutionLib.Tools;

namespace SolutionLib.Questions69 {
    public class Question69 : IQuestion {
        /*
        Implement int sqrt(int x).

        Compute and return the square root of x, where x is guaranteed to be a non-negative integer.

        Since the return type is an integer, the decimal digits are truncated and only the integer part of the result is returned.

        Example 1:

        Input: 4
        Output: 2
        Example 2:

        Input: 8
        Output: 2
        Explanation: The square root of 8 is 2.82842..., and since 
                    the decimal part is truncated, 2 is returned.
         */
        public void Run () {
            int x = 8;
            System.Console.WriteLine ("V1:");
            WatchDog.ShowPerformance (MySqrt, x);
        }

        public int MySqrt (int x) {
            int high = (int) Math.Sqrt (Int32.MaxValue);
            int low = 0;
            int mid = (high + low) / 2;

            while (true) {
                if (mid * mid == x)
                    return mid;
                else
                if (mid * mid < x && ((mid + 1) > x / (mid + 1)))
                    return mid;
                else
                if (mid * mid < x)
                    low = mid + 1;
                else
                if (mid * mid > x)
                    high = mid - 1;

                mid = (high + low) / 2;
            }

        }
    }
}