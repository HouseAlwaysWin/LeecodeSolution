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
                new char[5] { '1', '1', '0', '1', '0' },
                new char[5] { '1', '1', '0', '0', '0' },
                new char[5] { '0', '0', '0', '0', '0' }
            };

            char[][] test2 = new char[4][] {
                new char[5] { '1', '1', '0', '0', '0' },
                new char[5] { '1', '1', '0', '0', '0' },
                new char[5] { '0', '0', '1', '0', '0' },
                new char[5] { '0', '0', '0', '1', '1' }
            };
        }

        public int NumIslands (char[][] grid) {
            
            return -1;
        }

    }
}