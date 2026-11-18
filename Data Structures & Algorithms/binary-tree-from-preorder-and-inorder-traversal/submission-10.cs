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
    public int pre_idx = 0;
    public Dictionary<int,int> inorderMap = new Dictionary<int,int>();

    public TreeNode BuildTree(int[] preorder, int[] inorder) {        
        for(int i=0;i<inorder.Length;i++){
            if(!inorderMap.ContainsKey(inorder[i]))
                inorderMap[inorder[i]] = i;
        }
        return Build(preorder,0,inorder.Length - 1);
    }
    private TreeNode Build(int[] preorder, int l, int r){
        if(l>r) return null;
        int root_val = preorder[pre_idx++];
        TreeNode root = new TreeNode(root_val);
        int mid = inorderMap[root_val];
        root.left=Build(preorder,l,mid-1);
        root.right=Build(preorder,mid+1,r);
        return root;
    }
}
