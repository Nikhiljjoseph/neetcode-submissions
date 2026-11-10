/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {    
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0)
            return null;
        ListNode head = new ListNode();
        ListNode curr = head;
        var queue = new PriorityQueue<ListNode,int>();
        foreach(var node in lists){
            if(node != null)
                queue.Enqueue(node,node.val);
        }
        while(queue.Count > 0){
            var node=queue.Dequeue();
            if(node.next != null)
                queue.Enqueue(node.next,node.next.val);
            node.next=null;
            curr.next=node;
            curr=curr.next;
        }
        return head.next;
    }
}
