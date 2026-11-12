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
        return (dfs(root) != -1);
    }
    private int dfs(TreeNode root){
        if(root == null) return 0;
        int lH = dfs(root.left);
        if(lH == -1) return -1;
        int rH = dfs(root.right);
        if(rH == -1) return -1;
        if(Math.Abs(lH-rH)>1) return -1;
        return(1+Math.Max(lH,rH));
    }
}
