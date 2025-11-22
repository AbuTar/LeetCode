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
    public bool IsBalanced(TreeNode root) {

        return Depth_Check(root) != -1;
        
    }

    private int Depth_Check(TreeNode node){
        if (node == null){
            return 0;
        }

        int left = Depth_Check(node.left);
        if (left == -1){
            return left;
        }

        int right = Depth_Check(node.right);
        if (right == -1){
            return right;
        }

        if (Math.Abs(left - right) > 1){
            return -1; 
        }
            


        return Math.Max(left, right) + 1;

    }
}