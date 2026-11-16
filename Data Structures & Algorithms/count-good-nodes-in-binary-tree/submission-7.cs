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
    public int count = 0;
    public int GoodNodes(TreeNode root) {
        if(root==null)return 0;
        dfs(root,root.val);
        return count;
    }
    private void dfs(TreeNode root, int bestVal){
        if(root==null)return ;
        if(root.val>=bestVal){
            count++;
            bestVal=root.val;
        }
        dfs(root.right,bestVal);
        dfs(root.left,bestVal);
    }
}
