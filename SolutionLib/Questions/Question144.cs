using System.Collections.Generic;
using SolutionLib.Tools;

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
            TreeNode tree = new TreeNode (1) {
                left = new TreeNode (2) {
                left = new TreeNode (3),
                right = new TreeNode (4) {
                left = new TreeNode (5),
                right = new TreeNode (6)
                }
                },
                right = new TreeNode (7) {
                right = new TreeNode (8) {
                right = new TreeNode (9)
                }
                }
            };

            WatchDog.ShowPerformance (PreorderTraversal, tree);
        }
        List<int> list = new List<int> ();
        /// <summary>
        /// Recursive
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PreorderTraversal (TreeNode root) {

            if (root != null) {
                list.Add (root.val);
            }

            if (root != null && root.left != null) {
                PreorderTraversal (root.left);
            }

            if (root != null && root.right != null) {
                PreorderTraversal (root.right);
            }
            return list;
        }

        public IList<int> PreorderTraversalV2 (TreeNode root) {
            return null;
        }

    }
}