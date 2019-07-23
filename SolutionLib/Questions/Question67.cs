using System;
using SolutionLib.Tools;

namespace SolutionLib.Questions {
    public class Question67 : IQuestion {
        /*  Given two binary strings, return their sum (also a binary string).

            The input strings are both non-empty and contains only characters 1 or 0.

            Example 1:

            Input: a = "11", b = "1"
            Output: "100"

            Example 2:

            Input: a = "1010", b = "1011"
            Output: "10101" 
        */
        public void Run () {
            string a = "11";
            string b = "11";
            System.Console.WriteLine ("V1:");
            WatchDog.ShowPerformance (AddBinaryV2, a, b);
        }

        public string AddBinary (string a, string b) {
            var a_len = a.Length - 1;
            var b_len = b.Length - 1;
            var result = "";
            bool isCarry = false;
            while (true) {
                if (a_len >= 0 && b_len >= 0) {
                    if (a[a_len] == '0' && b[b_len] == '0') {
                        if (isCarry) {
                            result = "1" + result;
                        } else {
                            result = "0" + result;
                        }
                        isCarry = false;
                    } else if (a[a_len] == '1' && b[b_len] == '1') {
                        if (isCarry) {
                            result = "1" + result;
                        } else {
                            result = "0" + result;
                        }
                        isCarry = true;
                    } else {
                        if (isCarry) {
                            result = "0" + result;
                            isCarry = true;
                        } else {
                            result = "1" + result;
                            isCarry = false;
                        }
                    }
                }

                if (b_len < 0 && a_len >= 0) {
                    if (a[a_len] == '1' && isCarry) {
                        result = '0' + result;
                        isCarry = true;
                    } else if (a[a_len] == '0' && isCarry) {
                        result = '1' + result;
                        isCarry = false;
                    } else {
                        result = a[a_len] + result;
                    }
                } else if (a_len < 0 && b_len >= 0) {
                    if (b[b_len] == '1' && isCarry) {
                        result = '0' + result;
                        isCarry = true;
                    } else if (b[b_len] == '0' && isCarry) {
                        result = '1' + result;
                        isCarry = false;
                    } else {
                        result = b[b_len] + result;
                    }
                }

                if (a_len < 0 && b_len < 0) {
                    if (isCarry) {
                        result = '1' + result;
                    }
                    break;
                }
                a_len -= 1;
                b_len -= 1;

            }
            return result;
        }

        public string AddBinaryV2 (string a, string b) {
            if (a.Length < b.Length) a = a.PadLeft (b.Length, '0');
            if (a.Length > b.Length) b = b.PadLeft (a.Length, '0');

            var result = "";
            var carry = 0;
            for (var i = a.Length - 1; i >= 0; i--) {
                var aVal = a[i] == '1' ? 1 : 0;
                var bVal = b[i] == '1' ? 1 : 0;
                var total = aVal + bVal + carry;
                carry = 0;
                if (total >= 2) {
                    carry = 1;
                    total -= 2;
                }

                result = total + result;

            }

            if (carry == 1)
                result = 1 + result;
            if (result[0] == '0' && result.Length > 1)
                result = result.Substring (1);

            return result;
        }

    }
}