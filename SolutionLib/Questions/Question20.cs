using System.Collections.Generic;
using SolutionLib.Tools;

namespace SolutionLib.Questions {
    public class Question20 : IQuestion {
        /*
        Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
                                        
        An input string is valid if:

        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.
        Note that an empty string is also considered valid.

        Example 1:

        Input: "()"
        Output: true
        Example 2:

        Input: "()[]{}"
        Output: true
        Example 3:

        Input: "(]"
        Output: false
        Example 4:

        Input: "([)]"
        Output: false
        Example 5:

        Input: "{[]}"
        Output: true 
        */
        public void Run () {
            var input = "([)]";
            System.Console.WriteLine ("V1:");
            WatchDog.ShowPerformance (IsValid, input);
            System.Console.WriteLine ("V2:");
            WatchDog.ShowPerformance (IsValidV2, input);
        }

        public bool IsValidV2 (string s) {
            char[] stack = new char[s.Length / 2];
            int pointer = 0;

            try {
                foreach (char c in s) {
                    switch (c) {
                        case '(':
                        case '[':
                        case '{':
                            stack[pointer] = c;
                            pointer++;
                            break;
                        case ')':
                            if (stack[pointer - 1] == '(') {
                                stack[pointer - 1] = '\u0000';
                                pointer--;
                            } else {
                                return false;
                            }
                            break;
                        case ']':
                            if (stack[pointer - 1] == '[') {
                                stack[pointer - 1] = '\u0000';
                                pointer--;
                            } else {
                                return false;
                            }
                            break;
                        case '}':
                            if (stack[pointer - 1] == '{') {
                                stack[pointer - 1] = '\u0000';
                                pointer--;
                            } else {
                                return false;
                            }
                            break;
                        default:
                            return false;
                    }
                }
            } catch {
                return false;
            }

            if (pointer == 0) return true;
            else {
                return false;
            }
        }

        private bool IsValid (string s) {
            int lastPos = s.Length == 0 ? 0 : s.Length - 1;
            char[] symbol = new char[lastPos];

            if (s.Length % 2 != 0)
                return false;

            for (int i = 0; i < s.Length; i++) {
                switch (s[i]) {
                    case '(':
                    case '[':
                    case '{':
                        symbol[i] += s[i];
                        break;
                    case ')':
                        if (symbol.Length != 0) {
                            if (symbol[symbol.Length - 1] == '(') {
                                symbol[symbol.Length - 1] = ' ';
                            }
                        }
                        break;

                    case ']':
                        if (symbol.Length != 0) {
                            if (symbol[symbol.Length - 1] == '[') {
                                symbol[symbol.Length - 1] = ' ';
                            }
                        }
                        break;

                    case '}':
                        if (symbol.Length != 0) {
                            if (symbol[symbol.Length - 1] == '{') {
                                symbol[symbol.Length - 1] = ' ';
                            }
                        }
                        break;
                }
            }
            if (symbol[symbol.Length - 1] != 0) {
                return true;
            }
            return false;
        }
    }
}