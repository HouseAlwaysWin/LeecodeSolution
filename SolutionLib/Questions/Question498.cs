using SolutionLib.Tools;

namespace SolutionLib.Questions498 {
    public class Question498 : IQuestion {
        /*
        Given a matrix of M x N elements (M rows, N columns), return all elements of the matrix in diagonal order as shown in the below image.

        Example:

        Input:
        [
        [ 1, 2, 3 ],
        [ 4, 5, 6 ],
        [ 7, 8, 9 ]
        ]

        Output:  [1,2,4,7,5,3,6,8,9]

        Explanation:

         */
        /* 
            00,

            01,
            10,

            20,
            11,
            02,

            12,
            21,

            22
        */

        public void Run () {
            int[][] matrix = new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };
            WatchDog.ShowPerformance (FindDiagonalOrder, matrix);
        }

        public int[] FindDiagonalOrder (int[][] matrix) {
            if (matrix.Length == 0) {
                return new int[0];
            }

            int row = 0, col = 0;
            int m = matrix.Length;
            int n = matrix[0].Length;
            int[] aimArr = new int[m * n];

            for (int i = 0; i < aimArr.Length; i++) {
                aimArr[i] = matrix[row][col];
                if ((row + col) % 2 == 0) {
                    if (col == n - 1) {
                        row++;
                    } else if (row == 0) {
                        col++;
                    } else {
                        row--;
                        col++;
                    }
                } else {
                    if (row == m - 1) {
                        col++;
                    } else if (col == 0) {
                        row++;
                    } else {
                        col--;
                        row++;
                    }
                }
            }
            return aimArr;
        }
    }
}