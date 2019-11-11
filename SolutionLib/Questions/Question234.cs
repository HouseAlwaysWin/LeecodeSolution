using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using SolutionLib.Tools;

namespace SolutionLib.Questions {
    public class Question234 : IQuestion {
        /*
        Given a singly linked list, determine if it is a palindrome.

        Example 1:

        Input: 1->2
        Output: false
        Example 2:

        Input: 1->2->2->1
        Output: true
        Follow up:
        Could you do it in O(n) time and O(1) space?
         */
        public void Run () {
            ListNode list = new ListNode (1) {
                next = new ListNode (2) {
                next = new ListNode (3) {
                next = new ListNode (4) {
                next = new ListNode (5)
                }
                }
                }
            };

            ListNode list2 = new ListNode (1) {
                next = new ListNode (2) {
                next = new ListNode (3) {
                next = new ListNode (3) {
                next = new ListNode (2) {
                next = new ListNode (1)
                }
                }
                }
                }
            };
            WatchDog.ShowPerformance (IsPalindrome, list);
            WatchDog.ShowPerformance (IsPalindrome, list2);

        }

        public bool IsPalindrome (ListNode head) {
            var curr = head;
            Stack<int> stack = new Stack<int> ();
            while (curr != null) {
                stack.Push (curr.val);
                curr = curr.next;
            }
            curr = head;
            while (curr != null) {
                var node = stack.Pop ();
                if (curr.val != node) {
                    return false;
                }
                curr = curr.next;
            }
            return true;

        }

    }
}