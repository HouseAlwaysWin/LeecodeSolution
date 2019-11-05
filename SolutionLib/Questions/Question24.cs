using System.Threading;
using SolutionLib.Tools;

namespace SolutionLib.Questions {
    public class Question24 : IQuestion {
        /*
        Given a linked list, swap every two adjacent nodes and return its head.

        You may not modify the values in the list's nodes, only nodes itself may be changed.

        

        Example:

        Given 1->2->3->4, you should return the list as 2->1->4->3.
         */
        public void Run () {
            ListNode noloop = new ListNode (1) {
                next = new ListNode (2) {
                next = new ListNode (3)
                }
            };
            WatchDog.ShowPerformance<ListNode, ListNode> (SwapPairs, noloop);
        }

        public ListNode SwapPairs (ListNode head) {
            if (head == null || head.next == null) return head;
            ListNode prev = null, h = head.next;
            while (head != null && head.next != null) {
                var second = head.next;
                head.next = second.next;
                second.next = head;
                if (prev != null) prev.next = second;
                prev = head;
                head = head.next;
            }
            return h;
        }
    }
}