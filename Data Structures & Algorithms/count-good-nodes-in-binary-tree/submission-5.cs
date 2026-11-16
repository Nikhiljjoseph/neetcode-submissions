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
    public int GoodNodes(TreeNode root) {
        if(root==null)return 0;
        return dfs(root,root.val);
    }
    private int dfs(TreeNode root, int bestVal){
        if(root==null)return 0;
        int count = 0;
        if(root.val>=bestVal){
            count=1;
            bestVal=root.val;
        }
        count += dfs(root.right,bestVal);
        count += dfs(root.left,bestVal);
        return count;
    }
}
