using System;
using SolutionLib.Questions;
using SolutionLib.Tools;

namespace SolutionLib.Questions2 {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }

    }
    public class Question2 : IQuestion {
        /*
        You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

        You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        Example:

        Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        Output: 7 -> 0 -> 8
        Explanation: 342 + 465 = 807.
         */

        public void Run () {
            ListNode l1 = new ListNode (9) { };
            ListNode l2 = new ListNode (9);
            WatchDog.ShowPerformance<ListNode, ListNode, ListNode> (AddTwoNumbers, l1, l2);
        }

        public ListNode AddTwoNumbers (ListNode l1, ListNode l2) {
            if (l1 == null || l2 == null) return null;
            var head1 = l1;
            var head2 = l2;
            ListNode node = null;
            ListNode curr = null;
            int process = 0;
            while (head1 != null || head2 != null || process != 0) {
                int val = 0;
                if (head1 != null && head2 != null) {
                    val = head1.val + head2.val + process;
                } else if (head1 != null) {
                    val = head1.val + process;
                } else if (head2 != null) {
                    val = head2.val + process;
                } else {
                    val = process;
                }

                process = 0;
                if (val > 9) {
                    val = val - 10;
                    process = 1;
                }
                if (node == null) {
                    node = new ListNode (val);
                    curr = node;
                } else {
                    curr.next = new ListNode (val);
                    curr = curr.next;
                }

                if (head1 != null) {
                    head1 = head1.next;
                }
                if (head2 != null) {
                    head2 = head2.next;
                }
            }

            return node;
        }
    }
}