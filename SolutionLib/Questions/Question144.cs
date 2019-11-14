using System.Collections.Generic;

namespace SolutionLib.Questions144 {
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode (int x) { val = x; }
    }
    public class Question144 : IQuestion {
        /*
        Given a binary tree, return the preorder traversal of its nodes' values.

        Example:

        Input: [1,null,2,3]
        1
            \
            2
            /
        3

        Output: [1,2,3]
        Follow up: Recursive solution is trivial, could you do it iteratively?
         */
        public void Run () {
            throw new System.NotImplementedException ();
        }

        public IList<int> PreorderTraversal (TreeNode root) {
            return null;
        }
    }
}