using System.Collections.Generic;
using SolutionLib.Tools;

namespace SolutionLib.Questions {
    public class Question160 : IQuestion {
        /*
         Write a program to find the node at which the intersection of two singly linked lists begins.

            For example, the following two linked lists:


            begin to intersect at node c1.

            

            Example 1:


            Input: intersectVal = 8, listA = [4,1,8,4,5], listB = [5,0,1,8,4,5], skipA = 2, skipB = 3
            Output: Reference of the node with value = 8
            Input Explanation: The intersected node's value is 8 (note that this must not be 0 if the two lists intersect). From the head of A, it reads as [4,1,8,4,5]. From the head of B, it reads as [5,0,1,8,4,5]. There are 2 nodes before the intersected node in A; There are 3 nodes before the intersected node in B.
            

            Example 2:


            Input: intersectVal = 2, listA = [0,9,1,2,4], listB = [3,2,4], skipA = 3, skipB = 1
            Output: Reference of the node with value = 2
            Input Explanation: The intersected node's value is 2 (note that this must not be 0 if the two lists intersect). From the head of A, it reads as [0,9,1,2,4]. From the head of B, it reads as [3,2,4]. There are 3 nodes before the intersected node in A; There are 1 node before the intersected node in B.
            

            Example 3:


            Input: intersectVal = 0, listA = [2,6,4], listB = [1,5], skipA = 3, skipB = 2
            Output: null
            Input Explanation: From the head of A, it reads as [2,6,4]. From the head of B, it reads as [1,5]. Since the two lists do not intersect, intersectVal must be 0, while skipA and skipB can be arbitrary values.
            Explanation: The two lists do not intersect, so return null.
            

            Notes:

            If the two linked lists have no intersection at all, return null.
            The linked lists must retain their original structure after the function returns.
            You may assume there are no cycles anywhere in the entire linked structure.
            Your code should preferably run in O(n) time and use only O(1) memory.
         */
        public void Run () {
            ListNode same = new ListNode (8) {
                next = new ListNode (4) {
                next = new ListNode (5)
                }
            };

            ListNode headA = new ListNode (4) {
                next = new ListNode (1) {
                next = new ListNode (1) {
                next = new ListNode (2) {
                next = new ListNode (6) {
                next = new ListNode (8) {
                next = new ListNode (9) {
                next = same
                }
                }
                }
                }
                }
                }
            };

            ListNode headB = new ListNode (5) {
                next = new ListNode (0) {
                next = same
                }

            };

            WatchDog.ShowPerformance<ListNode, ListNode, ListNode> (GetIntersectionNode1, headA, headB);
            WatchDog.ShowPerformance<ListNode, ListNode, ListNode> (GetIntersectionNode2, headA, headB);
            WatchDog.ShowPerformance<ListNode, ListNode, ListNode> (GetIntersectionNode3, headA, headB);

        }

        public ListNode GetIntersectionNode1 (ListNode headA, ListNode headB) {
            var a = headA;
            var b = headB;
            while (a != null) {
                while (b != null) {
                    if (a == b) {
                        return a;
                    }
                    b = b.next;
                }
                b = headB;
                a = a.next;
            }
            return null;
        }

        public ListNode GetIntersectionNode2 (ListNode headA, ListNode headB) {
            if (headA == null || headB == null) return null;
            var alist = headA;
            var blist = headB;
            var alen = 0;
            var blen = 0;
            while (alist != null) {
                alen++;
                alist = alist.next;
            }
            while (blist != null) {
                blen++;
                blist = blist.next;
            }
            alist = headA;
            blist = headB;
            if (alen > blen) {
                var distance = alen - blen;
                while (distance-- > 0) {
                    alist = alist.next;
                }
            } else {
                var distance = blen - alen;
                while (distance-- > 0) {
                    blist = blist.next;
                }
            }
            while (alist != null) {
                if (alist == blist) return alist;
                alist = alist.next;
                blist = blist.next;
            }
            return null;
        }

        public ListNode GetIntersectionNode3 (ListNode headA, ListNode headB) {
            ListNode p = headA;
            ListNode q = headB;

            Dictionary<ListNode, int> node = new Dictionary<ListNode, int> ();

            while (p != null) {
                node[p] = p.val;
                p = p.next;
            }

            while (q != null) {
                if (node.ContainsKey (q))
                    return q;

                q = q.next;
            }

            return null;
        }

    }
}