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
    public void ReorderList(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        while(fast!=null && fast.next!=null){
            slow=slow.next;
            fast=fast.next.next;
        }
        ListNode mid = slow;
        ListNode prev=null;
        slow=slow.next;
        mid.next=null;
        while(slow!=null){
            ListNode temp = slow.next;
            slow.next=prev;
            prev=slow;
            slow=temp;
        }
        while(head!=null && prev!=null){
            ListNode tempH = head.next;
            ListNode tempS = prev.next;
            head.next=prev;
            head.next.next=tempH;
            head=head.next.next;
            prev=tempS;
        }
    }
}
