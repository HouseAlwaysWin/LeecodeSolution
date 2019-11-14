using SolutionLib.Tools;

namespace SolutionLib.Questions61 {

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }

    }
    public class Question61 : IQuestion {
        /*
        Given a linked list, rotate the list to the right by k places, 
        where k is non-negative.

        Example 1:

        Input: 1->2->3->4->5->NULL, k = 2
        Output: 4->5->1->2->3->NULL
        Explanation:
        rotate 1 steps to the right: 5->1->2->3->4->NULL
        rotate 2 steps to the right: 4->5->1->2->3->NULL
        Example 2:

        Input: 0->1->2->NULL, k = 4
        Output: 2->0->1->NULL
        Explanation:
        rotate 1 steps to the right: 2->0->1->NULL
        rotate 2 steps to the right: 1->2->0->NULL
        rotate 3 steps to the right: 0->1->2->NULL
        rotate 4 steps to the right: 2->0->1->NULL
         */
        public void Run () {
            ListNode node1 = new ListNode (1) {
                next = new ListNode (2) {
                next = new ListNode (3) {
                next = new ListNode (4) {
                next = new ListNode (5)
                }
                }
                }
            };
            WatchDog.ShowPerformance<ListNode, int, ListNode> (RotateRight, node1, 10);
        }

        public ListNode RotateRight (ListNode head, int k) {
            if (head == null) return head;
            var last = head;
            int length = 0;
            while (last != null) {
                last = last.next;
                length++;
            }
            int mov = length - (k % length);
            if (mov == length) return head;

            var curr = head;
            int index = 1;
            ListNode new_head = null, new_tail = null;
            while (curr.next != null) {
                if (index == mov) {
                    new_head = curr.next;
                    new_tail = curr;
                }
                curr = curr.next;
                index++;
            }
            var tmp = head;
            head = new_head;
            curr.next = tmp;
            new_tail.next = null;

            return head;
        }

    }
}