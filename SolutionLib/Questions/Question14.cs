using System;
using SolutionLib.Tools;

namespace SolutionLib.Questions
{
    public class Question14 : IQuestion
    {
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
        public void Run()
        {
            string[] strs = { "flower", "flow", "floight" };
<<<<<<< HEAD
            System.Console.WriteLine("V1:");
            WatchDog.ShowPerformance(LongestCommonPrefix, strs);
            System.Console.WriteLine("V2:");
            WatchDog.ShowPerformance(LongestCommonPrefixV2, strs);
            System.Console.WriteLine("V3:");
            WatchDog.ShowPerformance(LongestCommonPrefixV3, strs);
            System.Console.WriteLine("V4:");
            WatchDog.ShowPerformance(LongestCommonPrefixV4, strs);
            System.Console.WriteLine("V5:");
            WatchDog.ShowPerformance(LongestCommonPrefixV5, strs);

=======
            System.Console.WriteLine ("V1:");
            WatchDog.ShowPerformance (LongestCommonPrefix, strs);
            System.Console.WriteLine ("V2:");
            WatchDog.ShowPerformance (LongestCommonPrefixV2, strs);
            System.Console.WriteLine ("V3:");
            WatchDog.ShowPerformance (LongestCommonPrefixV3, strs);
>>>>>>> 2056296a3414f3574833ffaddd66bc4d8dd8fba2
        }

        public string LongestCommonPrefix(string[] strs)
        {
            string prefix = string.Empty;
            if (strs.Length == 0)
            {
                return prefix;
            }

            bool allfound = true;
            // loop through every characher
            for (int i = 0; i < strs[0].Length; i++)
            {
                // base on first word
                char c = strs[0][i];
                // loop through every word
                for (int j = 1; j < strs.Length; j++)
                {
                    // make sure word length longer than current length 
                    if (strs[j].Length > i)
                    {
                        if (strs[j][i] != c)
                        {
                            allfound = false;
                            break;
                        }
                    }
                    else
                    {
                        return prefix;
                    }
                }

                if (allfound)
                {
                    prefix += c.ToString();
                }
                else
                {
                    return prefix;
                }
            }
            return prefix;
        }

        /// <summary>
        ///  Horizontal scanning
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefixV2(string[] strs)
        {
            if (strs.Length == 0) return "";
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix)) return "";
                }
            return prefix;
        }

        /// <summary>
        /// Vertical scanning 
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefixV3(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                char c = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i == strs[j].Length || strs[j][i] != c)
                        return strs[0].Substring(0, i);
                }
            }
            return strs[0];
        }


        /// <summary>
        ///  Divide and conquer
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefixV4(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";
            return longestCommonPrefix(strs, 0, strs.Length - 1);
        }

        private string longestCommonPrefix(string[] strs, int l, int r)
        {
            if (l == r)
            {
                return strs[l];
            }
            else
            {
                int mid = (l + r) / 2;
                string lcpLeft = longestCommonPrefix(strs, l, mid);
                string lcpRight = longestCommonPrefix(strs, mid + 1, r);
                return CommonPrefix(lcpLeft, lcpRight);
            }
        }

        private string CommonPrefix(string left, string right)
        {
            int min = Math.Min(left.Length, right.Length);
            for (int i = 0; i < min; i++)
            {
                if (left[i] != right[i])
                    return left.Substring(0, i);
            }
            return left.Substring(0, min);
        }

        /// <summary>
        /// Binary search 
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public String LongestCommonPrefixV5(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";
            int minLen = int.MaxValue;
            foreach (string str in strs)
                minLen = Math.Min(minLen, str.Length);
            int low = 1;
            int high = minLen;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (IsCommonPrefix(strs, middle))
                    low = middle + 1;
                else
                    high = middle - 1;
            }
            return strs[0].Substring(0, (low + high) / 2);
        }

        private bool IsCommonPrefix(string[] strs, int len)
        {
            String str1 = strs[0].Substring(0, len);
            for (int i = 1; i < strs.Length; i++)
                if (!strs[i].StartsWith(str1))
                    return false;
            return true;
        }

    }
}