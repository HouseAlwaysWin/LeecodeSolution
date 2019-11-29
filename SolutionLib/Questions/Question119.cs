using System.Collections.Generic;
using SolutionLib.Tools;

namespace SolutionLib.Questions119 {
    public class Question119 : IQuestion {
        /*
        Given a non-negative index k where k ≤ 33, return the kth index row of the Pascal's triangle.

        Note that the row index starts from 0.


        In Pascal's triangle, each number is the sum of the two numbers directly above it.

        Example:

        Input: 3
        Output: [1,3,3,1]
        Follow up:

        Could you optimize your algorithm to use only O(k) extra space?
         */
        public void Run () {
            WatchDog.ShowPerformance (GetRow, 4);
        }

        public IList<int> GetRow (int rowIndex) {
            if (rowIndex > 33) {
                return null;
            }
            List<List<int>> list = new List<List<int>> ();
            list.Add (new List<int> ());
            list[0].Add (1);
            if (rowIndex == 0) {
                return list[0];
            }
            for (int i = 1; i < rowIndex + 1; i++) {
                List<int> row = new List<int> ();
                List<int> prev = list[i - 1];

                row.Add (1);
                for (int j = 1; j < i; j++) {
                    row.Add (prev[j - 1] + prev[j]);
                }
                row.Add (1);
                list.Add (row);
                if (rowIndex == i) {
                    return row;
                }
            }
            return null;
        }
    }
}