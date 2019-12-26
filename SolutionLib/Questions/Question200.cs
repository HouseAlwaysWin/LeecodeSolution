using System.Collections.Generic;
using SolutionLib.Tools;

namespace SolutionLib.Questions200 {
    /*
    Given a 2d grid map of '1's (land) and '0's (water), count the number of islands.
    An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. 
    You may assume all four edges of the grid are all surrounded by water.

    Example 1:

    Input:
    11110
    11010
    11000
    00000

    Output: 1
    Example 2:

    Input:
    11000
    11000
    00100
    00011

    Output: 3
     */
    public class Question200 : IQuestion {
        public void Run () {
            char[][] test1 = new char[4][] {
                new char[5] { '1', '1', '1', '1', '0' },
                new char[5] { '1', '1', '0', '0', '0' },
                new char[5] { '1', '1', '0', '1', '0' },
                new char[5] { '0', '0', '0', '0', '1' }
            };

            char[][] test2 = new char[4][] {
                new char[5] { '1', '1', '0', '0', '0' },
                new char[5] { '1', '1', '0', '0', '0' },
                new char[5] { '0', '0', '1', '0', '0' },
                new char[5] { '0', '0', '0', '1', '1' }
            };

            WatchDog.ShowPerformance (NumIslandsBFS, test1);
        }

        /// <summary>
        /// BFS Search solution
        /// Explain:
        /// 1. loop all node and find 1 to start the searching all connection
        /// 2. for example:
        /// {'1', '1', '1', '1', '0' },
        /// { '1', '1', '0', '0', '0' },
        /// { '1', '1', '0', '1', '0' },
        /// { '0', '0', '0', '0', '1' }
        /// the first searching will like this:
        /// turn down -> [0,0] -> [1,0] -> [2,0]
        /// turn up -> [2,1] -> [1,1] -> [0,1] 
        /// turn right -> [0,3] -> [0,4] -> finish
        /// and set all search node to 0 to make sure has already searched
        /// 3. go out recursive and start another search again repeat step 2.
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int NumIslandsBFS (char[][] grid) {
            int count = 0;

            //double for loops to vist all nodes in the gird
            for (int i = 0; i < grid.Length; i++) {
                for (int j = 0; j < grid[0].Length; j++) {
                    //if the value is 1, then we have to start to sink the island
                    if (grid[i][j] == '1') {
                        count++;
                        grid = Sink (grid, i, j);
                    }
                }
            }
            return count;
        }

        public char[][] Sink (char[][] grid, int r, int c) {
            if (grid[r][c] == '1') {
                grid[r][c] = '0';
            }

            //check up
            if (r - 1 >= 0 && grid[r - 1][c] == '1') {
                Sink (grid, r - 1, c);
            }
            //check down
            if (r + 1 < grid.Length && grid[r + 1][c] == '1') {
                Sink (grid, r + 1, c);
            }
            //check left
            if (c - 1 >= 0 && grid[r][c - 1] == '1') {
                Sink (grid, r, c - 1);
            }
            //check right
            if (c + 1 < grid[0].Length && grid[r][c + 1] == '1') {
                Sink (grid, r, c + 1);
            }

            return grid;
        }
    }

}