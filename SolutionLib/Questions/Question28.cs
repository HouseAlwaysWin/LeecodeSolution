using SolutionLib.Tools;

namespace SolutionLib.Questions {
    public class Question28 : IQuestion {
        /*
        Implement strStr().

        Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

        Example 1:

        Input: haystack = "hello", needle = "ll"
        Output: 2
        Example 2:

        Input: haystack = "aaaaa", needle = "bba"
        Output: -1
        Clarification:

        What should we return when needle is an empty string? This is a great question to ask during an interview.

        For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().
         */
        public void Run () {
            string haystack = "mississippi";
            // string haystack = "ppi";
            string needle = "ppi";
            System.Console.WriteLine ("V1:");
            WatchDog.ShowPerformance (StrStr, haystack, needle);
            System.Console.WriteLine ("V2:");
            WatchDog.ShowPerformance (StrStrV2, haystack, needle);
            System.Console.WriteLine ("V3:");
            WatchDog.ShowPerformance (StrStrV3, haystack, needle);
        }

        public int StrStr (string haystack, string needle) {
            if (string.IsNullOrEmpty (needle)) return 0;
            int len = needle.Length;
            for (int i = 0; i < haystack.Length; i++) {
                if (haystack.Length - i >= len) {
                    var haystr = haystack.Substring (i, len);
                    if (haystr == needle) {
                        return i;
                    }
                }
            }
            return -1;
        }

        public int StrStrV2 (string haystack, string needle) {
            if (needle == "")
                return 0;
            int hayPt = 0;
            int needPt = 0;
            while (hayPt < haystack.Length && needPt < needle.Length) {
                if (haystack[hayPt] == needle[needPt]) {
                    needPt++;
                } else {
                    if (needPt != 0) {
                        hayPt -= needPt;
                        needPt = 0;
                    }
                }
                hayPt++;
            }
            if (needPt == needle.Length) {
                return hayPt - needPt;
            } else {
                return -1;
            }
        }

        public int StrStrV3 (string haystack, string needle) {
            if (needle == null) {
                return 0;
            }
            int a = haystack.IndexOf (needle);
            return a;
        }
    }
}