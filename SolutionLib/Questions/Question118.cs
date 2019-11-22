using System.Collections.Generic;
using SolutionLib.Tools;

namespace SolutionLib.Questions118 {
    public class Question118 : IQuestion {
        /*
        Given a non-negative integer numRows, generate the first numRows of Pascal's triangle.


        In Pascal's triangle, each number is the sum of the two numbers directly above it.

        Example:

        Input: 5
        Output:
        [
        [1],
        [1,1],
        [1,2,1],
        [1,3,3,1],
        [1,4,6,4,1]
        ]
         */
        public void Run () {

            WatchDog.ShowPerformance (Generate, 5);
        }

        public IList<IList<int>> Generate (int numRows) {
            int[][] aimArr = new int[numRows][];
            int row = 1;
            for (int i = 0; i < aimArr.Length; i++) {
                for (int x = 0; x < numRows; x++) {
                    aimArr[i][x] = row;
                }
            }
        }
    }
}