using SolutionLib.Tools;

namespace SolutionLib.Questions876 {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }

    }

    public class Question876 : IQuestion {

        /*
        Given a non-empty, singly linked list with head node head, return a middle node of linked list.

        If there are two middle nodes, return the second middle node.

        

        Example 1:

        Input: [1,2,3,4,5]
        Output: Node 3 from this list (Serialization: [3,4,5])
        The returned node has value 3.  (The judge's serialization of this node is [3,4,5]).
        Note that we returned a ListNode object ans, such that:
        ans.val = 3, ans.next.val = 4, ans.next.next.val = 5, and ans.next.next.next = NULL.
        Example 2:

        Input: [1,2,3,4,5,6]
        Output: Node 4 from this list (Serialization: [4,5,6])
        Since the list has two middle nodes with values 3 and 4, we return the second one.
        

        Note:

        The number of nodes in the given list will be between 1 and 100.
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
            ListNode node2 = new ListNode (1) {
                next = new ListNode (2) {
                next = new ListNode (3) {
                next = new ListNode (4) {
                next = new ListNode (5) {
                next = new ListNode (6)
                }
                }
                }
                }
            };
            ListNode node3 = new ListNode (1) {
                next = new ListNode (2)
            };
            WatchDog.ShowPerformance<ListNode, ListNode> (MiddleNode, node1);
            WatchDog.ShowPerformance<ListNode, ListNode> (MiddleNode, node2);
            WatchDog.ShowPerformance<ListNode, ListNode> (MiddleNode, node3);

            WatchDog.ShowPerformance<ListNode, ListNode> (MiddleNodeV2, node1);
            WatchDog.ShowPerformance<ListNode, ListNode> (MiddleNodeV2, node2);
            WatchDog.ShowPerformance<ListNode, ListNode> (MiddleNodeV2, node3);
        }

        public ListNode MiddleNode (ListNode head) {
            if (head == null || head.next == null) return head;
            var curr = head;
            int length = 1;
            while (curr.next != null) {
                curr = curr.next;
                length++;
            }
            int index = length / 2;
            curr = head;
            int count = 0;
            while (curr.next != null) {
                if (count == index) {
                    return curr;
                }
                curr = curr.next;
                count++;
            }
            return curr;
        }

        public ListNode MiddleNodeV2 (ListNode head) {
            ListNode slow = head;
            ListNode fast = head;

            while (fast.next != null && fast.next.next != null) {
                slow = slow.next;
                fast = fast.next.next;
            }

            if (fast.next != null)
                return slow.next;

            return slow;
        }
    }
}