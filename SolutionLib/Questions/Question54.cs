using System.Collections.Generic;
using SolutionLib.Tools;

namespace SolutionLib.Questions54 {
    public class Question54 : IQuestion {
        /*
            Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.

            Example 1:

            Input:
            [
            [ 1, 2, 3 ],
            [ 4, 5, 6 ],
            [ 7, 8, 9 ]
            ]
            Output: [1,2,3,6,9,8,7,4,5]
            Example 2:

            Input:
            [
            [1, 2, 3, 4],
            [5, 6, 7, 8],
            [9,10,11,12]
            ]
            Output: [1,2,3,4,8,12,11,10,9,5,6,7]
         */
        public void Run () {
            int[][] matrix = new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };

            int[][] matrix2 = new int[][] {
                new int[] { 1, 2, 3, 10 },
                new int[] { 4, 5, 6, 11 },
                new int[] { 7, 8, 9, 12 },
            };

            int[][] matrix3 = new int[][] {
                new int[] { 1, 2, 3, 10 },
            };

            int[][] matrix4 = new int[][] {
                new int[] { 1, 2, 3, 10 },
                new int[] { 4, 5, 6, 11 },
                new int[] { 7, 8, 9, 12 },
                new int[] { 13, 14, 15, 16 },
            };
            WatchDog.ShowPerformance (SpiralOrder, matrix4);
        }

        public IList<int> SpiralOrder (int[][] matrix) {
            if (matrix == null) {
                return null;
            }
            if (matrix.Length == 0) {
                return matrix[0];
            }
            int row = 0, col = 0;
            int direction = 0;
            int min_row = 0;
            int min_col = 0;
            int max_row = matrix.Length - 1;
            int max_col = matrix[0].Length - 1;
            int[] aimArr = new int[matrix.Length * matrix[0].Length];

            for (int i = 0; i < aimArr.Length; i++) {
                aimArr[i] = matrix[row][col];
                if (direction == 0 && col < max_col && row == min_row) {
                    col++;
                } else if (direction == 0 && col == max_col) {
                    direction = 1;
                    min_row++;
                }

                if (direction == 1 && row < max_row && col == max_col) {
                    row++;
                } else if (direction == 1 && row == max_row) {
                    direction = 2;
                    max_col--;
                }

                if (direction == 2 && col > min_col && row == max_row) {
                    col--;
                } else if (direction == 2 && col == min_col) {
                    direction = 3;
                    max_row--;
                }

                if (direction == 3 && row > min_row && col == min_col) {
                    row--;
                } else if (direction == 3 && row == min_row) {
                    direction = 0;
                    min_col++;
                    col++;
                }

            }
            return aimArr;

        }
    }
}