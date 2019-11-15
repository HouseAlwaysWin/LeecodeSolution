using System.Collections.Generic;
using SolutionLib.Tools;

namespace SolutionLib.Questions83 {

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }

    }
    public class Question83 : IQuestion {
        /*
        Given a sorted linked list, delete all duplicates such that each element appear only once.

        Example 1:

        Input: 1->1->2
        Output: 1->2
        Example 2:

        Input: 1->1->2->3->3
        Output: 1->2->3
         */
        public void Run () {
            ListNode node = new ListNode (3) {
                next = new ListNode (1) {
                next = new ListNode (3) {
                next = new ListNode (2) {
                next = new ListNode (3) {
                next = new ListNode (1) {
                next = new ListNode (3)
                }

                }
                }
                }
                }
            };
            WatchDog.ShowPerformance<ListNode, ListNode> (DeleteDuplicatesV2, node);
            WatchDog.ShowPerformance<ListNode, ListNode> (DeleteDuplicates, node);

        }

        public ListNode DeleteDuplicates (ListNode head) {
            if (head == null) return head;
            ListNode curr = head;
            ListNode prev = head;
            List<int> check = new List<int> ();
            while (curr != null) {
                if (check.Contains (curr.val)) {
                    prev.next = curr.next;
                    curr = prev;
                } else {
                    check.Add (curr.val);
                }
                prev = curr;
                curr = curr.next;
            }
            return head;
        }

        public ListNode DeleteDuplicatesV2 (ListNode head) {
            if (head == null || head.next == null) {
                return head;
            }

            var start = head;
            while (start.next != null) {
                if (start.val == start.next.val) {
                    start.next = start.next.next;
                } else {
                    start = start.next;
                }
            }

            return head;
        }
    }
}