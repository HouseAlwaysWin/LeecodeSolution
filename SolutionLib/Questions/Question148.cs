using SolutionLib.Tools;

namespace SolutionLib.Questions {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) {
            val = x;
            next = null;
        }
    }
    public class Question148 : IQuestion {
        /*
        Sort a linked list in O(n log n) time using constant space complexity.

        Example 1:

        Input: 4->2->1->3
        Output: 1->2->3->4
        Example 2:

        Input: -1->5->3->4->0
        Output: -1->0->3->4->5
         */
        public void Run () {
            ListNode node = new ListNode (4) {
                next = new ListNode (2) {
                next = new ListNode (1) {
                next = new ListNode (3)
                }
                }
            };
            WatchDog.ShowPerformance<ListNode, ListNode> (SortList, node);
        }

        public ListNode SortList (ListNode head) {
            var curr = head;
            while (curr != null) {
                
                curr = curr.next;
            }
            return null;
        }
    }
}