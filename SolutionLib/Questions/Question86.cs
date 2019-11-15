using SolutionLib.Tools;

namespace SolutionLib.Questions86 {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }

    }
    public class Question86 : IQuestion {
        /*
        Given a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.

        You should preserve the original relative order of the nodes in each of the two partitions.

        Example:

        Input: head = 1->4->3->2->5->2, x = 3
        Output: 1->2->2->4->3->5
         */
        public void Run () {
            ListNode node = new ListNode (1) {
                next = new ListNode (4) {
                next = new ListNode (3) {
                next = new ListNode (2) {
                next = new ListNode (2) {
                next = new ListNode (5) {
                next = new ListNode (2)
                }
                }
                }
                }
                }
            };
            WatchDog.ShowPerformance<ListNode, int, ListNode> (Partition, node, 3);
        }

        public ListNode Partition (ListNode head, int x) {
            return null;
        }
    }
}