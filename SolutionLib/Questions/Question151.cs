using System.Text;
using SolutionLib.Tools;

namespace SolutionLib.Questions151 {
    public class Question151 : IQuestion {
        /*
        Given an input string, reverse the string word by word.

        Example 1:

        Input: "the sky is blue"
        Output: "blue is sky the"
        Example 2:

        Input: "  hello world!  "
        Output: "world! hello"
        Explanation: Your reversed string should not contain leading or trailing spaces.
        Example 3:

        Input: "a good   example"
        Output: "example good a"
        Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.
         */
        public void Run () {
            WatchDog.ShowPerformance (ReverseWords, "Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.");
        }

        public string ReverseWords (string s) {
            string word = string.Empty;
            string reverse = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--) {
                if (s[i] != ' ') {
                    word = s[i].ToString () + word;
                } else if (!string.IsNullOrWhiteSpace (word)) {
                    if (reverse == string.Empty) {
                        reverse = reverse + word;
                    } else {
                        reverse = reverse + " " + word;
                    }
                    word = string.Empty;
                }

            }
            if (!string.IsNullOrWhiteSpace (word)) {
                if (reverse == string.Empty) {
                    reverse = reverse + word;
                } else {
                    reverse = reverse + " " + word;
                }
            }

            return reverse;
        }

    }
}