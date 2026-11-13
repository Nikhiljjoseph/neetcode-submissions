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
    public List<int> RightSideView(TreeNode root) {
        var output = new List<int>();
        if(root == null) return output;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count != 0){
            TreeNode right = null;
            int count = queue.Count;
            for(int i=0; i<count; i++){
                var node = queue.Dequeue();
                if(node != null){
                    right=node;
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }
            if(right != null)
                output.Add(right.val);
        }
        return output;
    }
}
