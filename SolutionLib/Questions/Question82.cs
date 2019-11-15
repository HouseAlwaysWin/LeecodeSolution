using System.Collections.Generic;
using SolutionLib.Tools;

namespace SolutionLib.Questions82 {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }

    }

    public class Question82 : IQuestion {
        /*
        Given a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list.

        Example 1:

        Input: 1->2->3->3->4->4->5
        Output: 1->2->5
        Example 2:

        Input: 1->1->1->2->3
        Output: 2->3
         */
        public void Run () {
            ListNode node = new ListNode (3) {
                next = new ListNode (1) {
                next = new ListNode (3) {
                next = new ListNode (2) {
                next = new ListNode (3) {
                next = new ListNode (1) {
                next = new ListNode (3)
                }
                }
                }
                }
                }
            };
            WatchDog.ShowPerformance<ListNode, ListNode> (DeleteDuplicates, node);
        }

        public ListNode DeleteDuplicates (ListNode head) {
            if (head == null) return head;
            ListNode curr = head;
            Dictionary<int, int> check = new Dictionary<int, int> ();
            while (curr != null) {
                if (check.ContainsKey (curr.val)) {
                    check[curr.val]++;
                } else {
                    check.Add (curr.val, 1);
                }
                curr = curr.next;
            }
            curr = head;
            ListNode prev = null;
            while (curr!= null) {
                if (check[curr.val] > 1) {
                    if (prev == null) {
                        head = curr.next;
                        curr = head;
                        prev = null;
                        continue;
                    } else {
                        prev.next = curr.next;
                        curr = prev;
                    }
                }
                prev = curr;
                curr = curr.next;
            }

            return head;
        }
    }
}