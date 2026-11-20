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

public class Codec {
    public List<string> res = new List<string>();
    public int idx = 0;
    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        res.Clear();
        Sdfs(root);
        return string.Join(",", res);
    }

    private void Sdfs(TreeNode root){
        if(root==null){
            res.Add("N");
            return;
        };
        res.Add(root.val.ToString());
        Sdfs(root.left);
        Sdfs(root.right);
        return;
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        idx = 0;
        string[] arr = data.Split(",");
        return Ddfs(arr);
    }

    private TreeNode Ddfs(string[] arr){        
        if(arr[idx]=="N"){ 
            idx++;
            return null;
        }
        TreeNode root = new TreeNode(int.Parse(arr[idx]));
        idx++;
        root.left = Ddfs(arr);
        root.right = Ddfs(arr);
        return root;
    }
}
