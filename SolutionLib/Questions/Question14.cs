using SolutionLib.Tools;

namespace SolutionLib.Questions {
    public class Question14 : IQuestion {
        /*
        Write a function to find the longest common prefix string amongst an array of strings.

        If there is no common prefix, return an empty string "".

        Example 1:

        Input: ["flower","flow","flight"]
        Output: "fl"
        Example 2:

        Input: ["dog","racecar","car"]
        Output: ""
        Explanation: There is no common prefix among the input strings.
        Note:

        All given inputs are in lowercase letters a-z.
         */
        public void Run () {
            string[] strs = { "flower", "flow", "floight" };
            System.Console.WriteLine ("V1:");
            WatchDog.ShowPerformance (LongestCommonPrefix, strs);
            System.Console.WriteLine ("V2:");
            WatchDog.ShowPerformance (LongestCommonPrefixV2, strs);
            System.Console.WriteLine ("V3:");
            WatchDog.ShowPerformance (LongestCommonPrefixV3, strs);
        }

        public string LongestCommonPrefix (string[] strs) {
            string prefix = string.Empty;
            if (strs.Length == 0) {
                return prefix;
            }

            bool allfound = true;
            // loop through every characher
            for (int i = 0; i < strs[0].Length; i++) {
                // base on first word
                char c = strs[0][i];
                // loop through every word
                for (int j = 1; j < strs.Length; j++) {
                    // make sure word length longer than current length 
                    if (strs[j].Length > i) {
                        if (strs[j][i] != c) {
                            allfound = false;
                            break;
                        }
                    } else {
                        return prefix;
                    }
                }

                if (allfound) {
                    prefix += c.ToString ();
                } else {
                    return prefix;
                }
            }
            return prefix;
        }

        public string LongestCommonPrefixV2 (string[] strs) {
            if (strs.Length == 0) return "";
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
                while (strs[i].IndexOf (prefix) != 0) {
                    prefix = prefix.Substring (0, prefix.Length - 1);
                    if (string.IsNullOrEmpty (prefix)) return "";
                }
            return prefix;
        }

        public string LongestCommonPrefixV3 (string[] strs) {
            if (strs == null || strs.Length == 0) return "";
            for (int i = 0; i < strs[0].Length; i++) {
                char c = strs[0][i];
                for (int j = 1; j < strs.Length; j++) {
                    if (i == strs[j].Length || strs[j][i] != c)
                        return strs[0].Substring (0, i);
                }
            }
            return strs[0];
        }

    }
}