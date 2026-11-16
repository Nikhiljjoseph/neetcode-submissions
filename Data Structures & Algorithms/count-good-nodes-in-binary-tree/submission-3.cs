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
    public int result = 1;
    public int GoodNodes(TreeNode root) {
        if(root==null)return 0;
        dfs(root,root.val);
        return result;
    }
    private void dfs(TreeNode root, int bestVal){
        if(root==null)return;
        int rightBest=bestVal;
        int leftBest=bestVal;
        if(root.right!=null && root.right.val>=bestVal) {
            result++;
            rightBest=root.right.val;
        }
        if(root.left!=null && root.left.val>=bestVal) {
            result++;
            leftBest=root.left.val;
        }
        dfs(root.right,rightBest);
        dfs(root.left,leftBest);
    }
}
