using System.Collections.Generic;
using System.Linq;
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
            List<List<int>> list = new List<List<int>> ();
            if (numRows == 0) {
                return list.ToArray ();
            }
            list.Add (new List<int> ());
            list[0].Add (1);
            for (int i = 1; i < numRows; i++) {
                List<int> row = new List<int> ();
                List<int> prev = list[i - 1];
                row.Add (1);

                for (int j = 1; j < i; j++) {
                    row.Add (prev[j - 1] + prev[j]);
                }
                row.Add (1);
                list.Add (row);
            }

            return list.ToArray ();
        }
    }
}