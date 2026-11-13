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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        int min = Math.Min(p.val,q.val);
        int max = Math.Max(p.val,q.val);
        while(true){
        //if current node.val is less than min, traverse the left tree
        if(root.val < min) root = root.right;
        //if the current node.val is greater than max, traverse right tree
        if(root.val > max) root = root.left;
        //if the current node.val is between min and max(including), this is lca.
        else
            return root;
        }
    }
}
