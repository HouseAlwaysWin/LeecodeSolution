using SolutionLib.Tools;

namespace SolutionLib.Questions {

    /*
    Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.

    Example:

    Input: 1->2->4, 1->3->4
    Output: 1->1->2->3->4->4
     */
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }

    }
    public class Question21 : IQuestion {
        public void Run () {
            ListNode n1 = new ListNode (1) {
                next = new ListNode (2) {
                next = new ListNode (3)
                }
            };
            ListNode n2 = new ListNode (4) {
                next = new ListNode (5) {
                next = new ListNode (6)
                }
            };
            WatchDog.ShowPerformance (MergeTwoLists, n1, n2, false);
        }

        public ListNode MergeTwoLists (ListNode l1, ListNode l2) {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            if (l1.val < l2.val) {
                l1.next = MergeTwoLists (l1.next, l2);
                return l1;
            } else {
                l2.next = MergeTwoLists (l1, l2.next);
                return l2;
            }
        }

    }
}