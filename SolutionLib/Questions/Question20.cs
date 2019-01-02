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
            var input = "[(){}[]]";
            WatchDog.ShowPerformance (IsValid, input);
        }

        public bool IsValid (string s) {
            if (s.Length % 2 != 0)
                return false;

            char[] stack = new char[s.Length/2];
            int pos = 0;

            foreach (char c in s) {
                switch (c) {
                    case '(':
                    case '[':
                    case '{':
                        stack[pos] = c;
                        pos++;
                        break;
                    case ')':
                        if (stack[pos - 1] == '(') {
                            pos--;
                        } else {
                            return false;
                        }
                        break;
                    case ']':
                        if (stack[pos - 1] == '[') {
                            pos--;
                        } else {
                            return false;
                        }
                        break;
                    case '}':
                        if (stack[pos - 1] == '{') {
                            pos--;
                        } else {
                            return false;
                        }
                        break;
                    default:
                        return false;
                }
            }
            if (pos == 0) return true;
            else {
                return false;
            }
        }

    }
}