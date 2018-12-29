using System;
using System.Collections;
using System.Collections.Generic;
using SolutionLib.Tools;

namespace SolutionLib.Questions
{
    public class Question13 : IQuestion
    {
        /*
        Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
        
        Symbol       Value
        I             1
        V             5
        X             10
        L             50
        C             100
        D             500
        M             1000
        For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.

        Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

        I can be placed before V (5) and X (10) to make 4 and 9. 
        X can be placed before L (50) and C (100) to make 40 and 90. 
        C can be placed before D (500) and M (1000) to make 400 and 900.
        Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.

        Example 1:

        Input: "III"
        Output: 3
        Example 2:

        Input: "IV"
        Output: 4
        Example 3:

        Input: "IX"
        Output: 9
        Example 4:

        Input: "LVIII"
        Output: 58
        Explanation: L = 50, V= 5, III = 3.
        Example 5:

        Input: "MCMXCIV"
        Output: 1994
        Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
         */
        public void Run()
        {
            System.Console.WriteLine("RomanToInt Performance and Result:");
            WatchDog.ShowPerformance(RomanToInt, "MCMXCIV");
            System.Console.WriteLine("RomanToIntV2 Performance and Result:");
            WatchDog.ShowPerformance(RomanToIntV2, "MMMCMXL");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private int RomanToIntV2(string s)
        {
            int i = s.Length - 1;
            int prevNum = 0;
            int result = 0;
            while (i >= 0)
            {
                char word = s[i];
                int num = 0;
                switch (word)
                {
                    case 'I':
                        num = 1;
                        break;
                    case 'V':
                        num = 5;
                        break;
                    case 'X':
                        num = 10;
                        break;
                    case 'L':
                        num = 50;
                        break;
                    case 'C':
                        num = 100;
                        break;
                    case 'D':
                        num = 500;
                        break;
                    case 'M':
                        num = 1000;
                        break;
                    default:
                        return 0;
                }
                if (i == s.Length - 1)
                {
                    result = num;
                }
                else
                {
                    if (num >= prevNum)
                    {
                        result += num;
                    }
                    else
                    {
                        result -= num;
                    }
                }

                prevNum = num;
                i--;
            }

            return result;
        }
        private int RomanToInt(string s)
        {
            Dictionary<char, int> romanMapping = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            int number = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int word = romanMapping[s[i]];
                int nextword = 0;
                if (i != s.Length - 1)
                {
                    nextword = romanMapping[s[i + 1]];
                }
                else
                {
                    nextword = romanMapping[s[i]];
                }

                if (word >= nextword)
                {
                    number += word;
                }
                else
                {
                    number -= word;
                }
            }

            return 0;
        }
    }
}