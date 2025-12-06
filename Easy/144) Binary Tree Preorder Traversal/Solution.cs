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
    public IList<int> PreorderTraversal(TreeNode root) {

        List<int> list = new List<int>();

        Traverse(root, list);
        return list;
    }

    public void Traverse(TreeNode node, List<int> list){

        if (node == null){
            return;
        }

        list.Add(node.val);
        Traverse(node.left, list);
        Traverse(node.right, list);
    } 

}