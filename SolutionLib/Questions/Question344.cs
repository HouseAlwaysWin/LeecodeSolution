using SolutionLib.Tools;

namespace SolutionLib.Questions344 {
    public class Question344 : IQuestion {
        /*
        Write a function that reverses a string. The input string is given as an array of characters char[].

        Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

        You may assume all the characters consist of printable ascii characters.

        

        Example 1:

        Input: ["h","e","l","l","o"]
        Output: ["o","l","l","e","h"]
        Example 2:

        Input: ["H","a","n","n","a","h"]
        Output: ["h","a","n","n","a","H"]
         */
        public void Run () {
            var input = new char[] { 'h', 'e', 'l', 'l', 'o' };
            WatchDog.ShowPerformance<char[]> (ReverseString, input);
            WatchDog.ShowPerformance<char[]> (ReverseStringV2, input);
        }

        public void Reverse (char[] s, int head, int tail) {
            if (head > tail) return;
            var tmp = s[head];
            s[head++] = s[tail];
            s[tail--] = tmp;
            Reverse (s, head, tail);
        }
        public void ReverseString (char[] s) {
            Reverse (s, 0, s.Length - 1);
        }

        public void ReverseStringV2 (char[] s) {
            int head = 0, tail = s.Length - 1;
            while (head < tail) {
                var temp = s[head];
                s[head] = s[tail];
                s[tail] = temp;
                head++;
                tail--;
            }
        }
    }
}