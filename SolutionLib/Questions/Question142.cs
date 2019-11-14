using System.Collections.Generic;
using SolutionLib.Tools;

namespace SolutionLib.Questions142 {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) {
            val = x;
            next = null;
        }
    }
    public class Question142 : IQuestion {
        /*
                    Given a linked list, return the node where the cycle begins. If there is no cycle, return null.

                    To represent a cycle in the given linked list, we use an integer pos which represents the position (0-indexed) in the linked list where tail connects to. If pos is -1, then there is no cycle in the linked list.

                    Note: Do not modify the linked list.

        

                    Example 1:

                    Input: head = [3,2,0,-4], pos = 1
                    Output: tail connects to node index 1
                    Explanation: There is a cycle in the linked list, where tail connects to the second node.


                    Example 2:

                    Input: head = [1,2], pos = 0
                    Output: tail connects to node index 0
                    Explanation: There is a cycle in the linked list, where tail connects to the first node.


                    Example 3:

                    Input: head = [1], pos = -1
                    Output: no cycle
                    Explanation: There is no cycle in the linked list.

                     */
        public void Run () {
            ListNode node = new ListNode (1) {
                next = new ListNode (2) {
                next = new ListNode (3)
                }
            };
            WatchDog.ShowPerformance<ListNode, ListNode> (DetectCycle, node);

            var curr = node;
            while (curr != null) {
                curr = curr.next;
            }
            curr.next = node;
            WatchDog.ShowPerformance<ListNode, ListNode> (DetectCycle, node);
        }

        public ListNode DetectCycle (ListNode head) {
            HashSet<ListNode> set = new HashSet<ListNode> ();
            while (head != null && set.Add (head)) {
                head = head.next;
            }
            return head;
        }
    }
}