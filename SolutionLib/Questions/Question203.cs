using SolutionLib.Tools;

namespace SolutionLib.Questions203 {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }

    }
    public class Question203 : IQuestion {
        /*
        Remove all elements from a linked list of integers that have value val.

        Example:

        Input:  1->2->6->3->4->5->6, val = 6
        Output: 1->2->3->4->5
         */

        public void Run () {
            ListNode list = new ListNode (2) {
                next = new ListNode (2) {
                next = new ListNode (4) {
                next = new ListNode (4) {
                next = new ListNode (9) {
                next = new ListNode (9)
                }
                }
                }
                }
            };

            WatchDog.ShowPerformance<ListNode, int, ListNode> (RemoveElements, list, 2);
            WatchDog.ShowPerformance<ListNode, int, ListNode> (RemoveElements, list, 9);
        }

        public ListNode RemoveElements (ListNode head, int val) {
            var refs = head;
            ListNode prev = null;

            while (refs != null) {
                if (refs.val == val) {
                    if (prev == null) {
                        head = head.next;
                        refs = head;
                        prev = null;
                        continue;
                    } else {
                        prev.next = refs.next;
                        refs = prev;
                    }
                }
                prev = refs;
                refs = refs.next;
            }
            return head;
        }
    }
}