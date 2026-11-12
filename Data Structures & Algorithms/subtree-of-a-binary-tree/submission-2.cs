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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root == null) return false;
        if(dfs(root,subRoot)) return true;
        return IsSubtree(root.left,subRoot) || IsSubtree(root.right,subRoot);
    }
    private bool dfs(TreeNode p, TreeNode q){
        if(p==null || q==null) return p==q;
        if(p.val != q.val) return false;
        if(!dfs(p.left,q.left)) return false;
        if(!dfs(p.right,q.right)) return false;
        return true;
    }
}
