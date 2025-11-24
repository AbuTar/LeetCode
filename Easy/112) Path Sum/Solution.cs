/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {

        if (root == null)
            return false;

        if (root.left == null && root.right == null)
            return targetSum == root.val;

        // Recurse on children with reduced target
        int leftover = targetSum - root.val;

        return HasPathSum(root.left, leftover) ||
               HasPathSum(root.right, leftover);
        
    }
}