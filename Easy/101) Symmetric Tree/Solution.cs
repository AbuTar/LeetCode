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
    public bool IsSymmetric(TreeNode root) {
        if (root == null){
            return true;
        }

        return Helper(root.left, root.right);  
    }

    public bool Helper(TreeNode A, TreeNode B){
        if (A == null && B == null){
            return true;
        }

        if (A == null || B == null){
            return false;
        }

        return ((A.val == B.val)
                && Helper(A.left, B.right)
                && Helper(A.right, B.left));
    }
        
}