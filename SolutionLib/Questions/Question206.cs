using SolutionLib.Tools;

namespace SolutionLib.Questions {
    public class Question206 : IQuestion {
        /*
        Reverse a singly linked list.

        Example:

        Input: 1->2->3->4->5->NULL
        Output: 5->4->3->2->1->NULL
        Follow up:

        A linked list can be reversed either iteratively or recursively. Could you implement both?
         */
        public void Run () {
            ListNode node = new ListNode (1) {
                next = new ListNode (2) {
                next = new ListNode (3) {
                next = new ListNode (4) {
                next = new ListNode (5)
                }
                }
                }
            };
            WatchDog.ShowPerformance (ReverseList, node);
        }

        public ListNode ReverseList (ListNode head) {
            ListNode prev = null;
            var curr = head;
            while (curr != null) {
                ListNode nextTmp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTmp;
            }

            return prev;
        }

    }
}