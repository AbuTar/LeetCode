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
    public IList<int> InorderTraversal(TreeNode root) {

        List<int> output = new List<int>();

        if (root == null){
            return output;

        }

        //left
        foreach (var i in InorderTraversal(root.left)){
            output.Add(i);
        }

        //root
        output.Add(root.val);


        //right
        foreach (var j in InorderTraversal(root.right)){
            output.Add(j);
        }

        return output;
            
        
    }
}