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
    public List<List<int>> LevelOrder(TreeNode root) {
        var output = new List<List<int>>();
        if(root == null) return output;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count!=0){
            int qLength = queue.Count;
            var list = new List<int>();
            for(int i=0;i<qLength;i++){
                var node = queue.Dequeue();
                if(node != null){
                    list.Add(node.val);
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }
            if(list.Count > 0)
                output.Add(list);
        }
        return output;
    }
}
