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
    public int MinDepth(TreeNode root) {
        return Depth_Check(root);

    }

    private int Depth_Check(TreeNode node){
        if (node == null){
            return 0;
        }

        if (node.left == null && node.right == null){
            return 1;
        }

        if (node.left == null){
            
            return Depth_Check(node.right) + 1;
        }

        if (node.right == null)
        {
            return Depth_Check(node.left) + 1;
        }

        

        
        return Math.Min(Depth_Check(node.left), Depth_Check(node.right)) + 1;


    }
        
    
}
