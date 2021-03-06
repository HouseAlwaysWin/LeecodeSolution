using System.Net.NetworkInformation;
using SolutionLib.Tools;

namespace SolutionLib.Questions328 {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }

    }
    public class Question328 : IQuestion {
        /*
        Given a singly linked list, group all odd nodes together followed by the even nodes. 
        Please note here we are talking about the node number and not the value in the nodes.

        You should try to do it in place. 
        The program should run in O(1) space complexity and O(nodes) time complexity.

        Example 1:

        Input: 1->2->3->4->5->NULL
    
        Output: 1->3->5->2->4->NULL
        Example 2:

        Input: 2->1->3->5->6->4->7->NULL
        Output: 2->3->6->7->1->5->4->NULL
        Note:

        The relative order inside both the even and odd groups should remain as it was in the input.
        The first node is considered odd, the second node even and so on ...
         */

        public void Run () {
            ListNode list = new ListNode (1) {
                next = new ListNode (2) {
                next = new ListNode (3) {
                next = new ListNode (4) {
                next = new ListNode (5)
                }
                }
                }
            };
            WatchDog.ShowPerformance<ListNode, ListNode> (OddEvenList, list);
        }

        public ListNode OddEvenList (ListNode head) {
            if (head == null) return null;
            var odd = head;
            var even = head.next;
            ListNode evenHead = even;
            while (even != null && even.next != null) {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenHead;
            return head;
        }

    }
}