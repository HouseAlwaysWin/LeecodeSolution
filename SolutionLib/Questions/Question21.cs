namespace SolutionLib.Questions
{
    public class Question21 : IQuestion
    {
        /*
        Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.

        Example:

        Input: 1->2->4, 1->3->4
        Output: 1->1->2->3->4->4
        */
        public void Run()
        {
            throw new System.NotImplementedException();
        }

        /**
            * Definition for singly-linked list.
            * public class ListNode {
            *     public int val;
            *     public ListNode next;
            *     public ListNode(int x) { val = x; }
            * }
         */
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

        }
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}