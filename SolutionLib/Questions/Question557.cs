using System.Linq;
using SolutionLib.Tools;

namespace SolutionLib.Questions557 {
    public class Question557 : IQuestion {
        /*
        Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

        Example 1:
        Input: "Let's take LeetCode contest"
        Output: "s'teL ekat edoCteeL tsetnoc"
        Note: In the string, each word is separated by single space and there will not be any extra space in the string.
        */
        public void Run () {
            WatchDog.ShowPerformance (ReverseWords, "Let's take LeetCode contest");
        }

        public string ReverseWords (string s) {
            string reverse = string.Empty;
            string word = string.Empty;
            for (int i = 0; i < s.Length; i++) {
                if (s[i] != ' ') {
                    word = word + s[i].ToString ();
                } else {
                    if (!string.IsNullOrWhiteSpace (word)) {
                        string rev = string.Empty;
                        for (int j = word.Length - 1; j >= 0; j--) {
                            rev += word[j];
                        }
                        word = rev;
                        if (reverse == string.Empty) {
                            reverse = reverse + word;
                        } else {
                            reverse = reverse + " " + word;
                        }
                        word = string.Empty;
                    }
                }
            }
            if (!string.IsNullOrWhiteSpace (word)) {
                string rev = string.Empty;
                for (int j = word.Length - 1; j >= 0; j--) {
                    rev += word[j];
                }
                word = rev;
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