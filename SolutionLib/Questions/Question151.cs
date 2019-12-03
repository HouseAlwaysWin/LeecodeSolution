using System.Collections.Generic;
using System.Linq;
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
            WatchDog.ShowPerformance (ReverseWords, "a good   example");
        }

        public string ReverseWords (string s) {

            List<string> words = new List<string> ();
            string word = string.Empty;

            for (int i = 0; i < s.Length; i++) {
                if (!char.IsWhiteSpace (s[i])) {
                    word += s[i];
                } else {
                    if (!string.IsNullOrWhiteSpace (word)) {
                        words.Add (word);
                    }
                    word = string.Empty;
                }
            }
            if (!string.IsNullOrWhiteSpace (word)) {
                words.Add (word);
            }

            string result = string.Empty;
            for (int i = words.Count - 1; i >= 0; i--) {
                result += words[i];
                if (i != 0) {
                    result += " ";
                }
            }
            return result;
        }

    }
}