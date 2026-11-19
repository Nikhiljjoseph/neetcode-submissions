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
    public int sum = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        dfs(root);
        return sum;
    }
    private int dfs(TreeNode root){
        if(root == null) return 0;
        int lV = Math.Max(0,dfs(root.left));
        int rV = Math.Max(0,dfs(root.right));
        sum=Math.Max(sum,root.val+lV+rV);
        return (root.val+Math.Max(lV,rV));
    }
}
