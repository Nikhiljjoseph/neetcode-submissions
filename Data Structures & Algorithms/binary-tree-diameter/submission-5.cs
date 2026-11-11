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
    public int result = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        dfs(root);
        return result;
    }
    private int dfs(TreeNode root){
        if(root == null) return 0;
        int lH = dfs(root.left);
        int rH = dfs(root.right);
        result=Math.Max(result,lH+rH);
        return (1+Math.Max(lH,rH));
    }
}
