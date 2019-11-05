using System;
using System.Net.NetworkInformation;
namespace SolutionLib.Questions {
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
            throw new System.NotImplementedException ();
        }

        public ListNode RemoveNthFromEnd (ListNode head, int n) {
            if (head == null) return null;
            int len = 0;
            var refs = head;
            while (refs.next != null) {
                refs = refs.next;
                len++;
            }
            int index = len - n;
            if (Math.Abs (index) > len) return null;
            int count = 0;
            var prev = head;
            while (count != index) {
                prev = prev.next;
                count++;
            }

            if (prev != null && prev.next != null) {
                prev.next = prev.next.next;
            }

            return head;
        }
    }
}