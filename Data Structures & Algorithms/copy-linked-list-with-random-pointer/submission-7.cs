/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Node curr = head;
        var map = new Dictionary<Node, Node>();
        while(curr != null){
            Node copy = new Node(curr.val);
            map[curr] = copy;
            curr = curr.next;
        }
        curr=head;
        while(curr != null){
            Node copy =  map[curr];
            copy.next = curr.next == null ? null : map[curr.next];
            copy.random = curr.random == null ? null : map[curr.random];
            curr = curr.next;
        }
        return head==null? head:map[head];
    }
}
