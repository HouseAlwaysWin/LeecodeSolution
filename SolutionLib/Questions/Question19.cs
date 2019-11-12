using System;
using System.Net.NetworkInformation;
using System.Security.Principal;
using SolutionLib.Tools;

namespace SolutionLib.Questions19 {

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }

    }
    public class Question19 : IQuestion {
        /*
        Given a linked list, remove the n-th node from the end of list and return its head.

        Example:

        Given linked list: 1->2->3->4->5, and n = 2.

        After removing the second node from the end, the linked list becomes 1->2->3->5.
        Note:

        Given n will always be valid.

        Follow up:

        Could you do this in one pass?
         */

        public void Run () {
            ListNode test1 = new ListNode (1) {
                next = new ListNode (2) {
                next = new ListNode (3) {
                next = new ListNode (4) {
                next = new ListNode (5)
                }
                }
                }
            };

            ListNode test2 = new ListNode (1) {
                next = new ListNode (2)
            };

            WatchDog.ShowPerformance<ListNode, int, ListNode> (RemoveNthFromEnd, test1, 2);
            WatchDog.ShowPerformance<ListNode, int, ListNode> (RemoveNthFromEnd, test2, 2);
        }

        public ListNode RemoveNthFromEnd (ListNode head, int n) {
            if (head == null) return null;
            int max = 1;
            var refs = head;
            while (refs.next != null) {
                refs = refs.next;
                max++;
            }

            int index = max - n;
            int count = 0;
            var prev = head;
            if (index == 0) {
                head = head.next;
                return head;
            }
            while (count < index - 1) {
                prev = prev.next;
                count++;
            }

            if (prev.next != null) {
                prev.next = prev.next.next;
            }

            return head;
        }
    }
}