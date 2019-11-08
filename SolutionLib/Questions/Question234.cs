namespace SolutionLib.Questions {
    public class Question234 : IQuestion {
        /*
        Given a singly linked list, determine if it is a palindrome.

        Example 1:

        Input: 1->2
        Output: false
        Example 2:

        Input: 1->2->2->1
        Output: true
        Follow up:
        Could you do it in O(n) time and O(1) space?
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

            ListNode list2 = new ListNode (1) {
                next = new ListNode (2) {
                next = new ListNode (3) {
                next = new ListNode (3) {
                next = new ListNode (2) {
                next = new ListNode (1)
                }
                }
                }
                }
            };
        }

        public bool IsPalindrome (ListNode head) {
            var refs = head;
            var count = 1;
            while (head != null) {
                refs = refs.next;
                count++;
            }
            if (count % 2 != 0) return false;
            var index = count / 2;
            return false;

        }

    }
}