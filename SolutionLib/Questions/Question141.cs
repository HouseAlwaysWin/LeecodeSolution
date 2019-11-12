using SolutionLib.Tools;

namespace SolutionLib.Questions141 {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }

    }
    public class Question141 : IQuestion {
        /*
        Given a linked list, determine if it has a cycle in it.

        To represent a cycle in the given linked list, we use an integer pos which represents the position (0-indexed) in the linked list where tail connects to. If pos is -1, then there is no cycle in the linked list.

        

        Example 1:

        Input: head = [3,2,0,-4], pos = 1
        Output: true
        Explanation: There is a cycle in the linked list, where tail connects to the second node.


        Example 2:

        Input: head = [1,2], pos = 0
        Output: true
        Explanation: There is a cycle in the linked list, where tail connects to the first node.


        Example 3:

        Input: head = [1], pos = -1
        Output: false
        Explanation: There is no cycle in the linked list.


        

        Follow up:

        Can you solve it using O(1) (i.e. constant) memory?
         */

        public void Run () {
            ListNode noloop = new ListNode (1) {
                next = new ListNode (2) {
                next = new ListNode (3)
                }
            };
            ListNode loop = new ListNode (1) {
                next = new ListNode (2) {
                next = new ListNode (3) { }
                }
            };
            loop.next.next = loop;
            WatchDog.ShowPerformance<ListNode, bool> (HasCycle, noloop);
            WatchDog.ShowPerformance<ListNode, bool> (HasCycle, loop);
        }

        public bool HasCycle (ListNode head) {
            // Initialize slow & fast pointers
            ListNode slow = head;
            ListNode fast = head;
            /**
             * Change this condition to fit specific problem.
             * Attention: remember to avoid null-pointer error
             **/
            while (slow != null && fast != null && fast.next != null) {
                slow = slow.next; // move slow pointer one step each time
                fast = fast.next.next; // move fast pointer two steps each time
                if (slow == fast) { // change this condition to fit specific problem
                    return true;
                }
            }
            return false;
        }
    }
}