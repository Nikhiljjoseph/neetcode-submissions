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
    public bool result = true;
    public bool IsValidBST(TreeNode root) {
        if(root == null) return false;
        dfs(root.left,int.MinValue,root.val);
        dfs(root.right,root.val,int.MaxValue);
        return result; 
    }
    private void dfs(TreeNode root, int min, int max){
        if(root==null)return;
        if(!(root.val< max && root.val>min)){
            result = false;
            return;
        }   
        dfs(root.left,min,root.val);
        dfs(root.right,root.val,max);    
    }
}
