using System.Collections.Generic;
using SolutionLib.Tools;

namespace SolutionLib.Questions94 {

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode (int x) { val = x; }
    }
    public class Question94 : IQuestion {
        /*
        Given a binary tree, return the inorder traversal of its nodes' values.

        Example:

        Input: [1,null,2,3]
        1
            \
            2
            /
        3

        Output: [1,3,2]
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

            WatchDog.ShowPerformance (InorderTraversal, tree);
        }

        public IList<int> InorderTraversal (TreeNode root) {
            return null;
        }
    }
}