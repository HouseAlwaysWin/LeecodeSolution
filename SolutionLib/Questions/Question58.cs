using SolutionLib.Tools;

namespace SolutionLib.Questions58 {
    public class Question58 : IQuestion {
        /*
        Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.

        If the last word does not exist, return 0.

        Note: A word is defined as a character sequence consists of non-space characters only.

        Example:

        Input: "Hello World"
        Output: 5
         */
        public void Run () {
            string s = "Hello World sdf    ";
            System.Console.WriteLine ("V1:");
            WatchDog.ShowPerformance (LengthOfLastWord, s);
        }

        public int LengthOfLastWord (string s) {
            int count = 0;
            for (int i = s.Length - 1; i >= 0; i--) {
                if (s[i] != ' ') {
                    count += 1;
                } else if (count > 0) {
                    break;
                }
            }
            return count;
        }

    }
}