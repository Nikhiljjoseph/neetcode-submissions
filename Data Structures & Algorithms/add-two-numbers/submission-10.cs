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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode curr = new ListNode();
        ListNode head = curr;
        int carry = 0;
        while(l1!=null || l2!=null || carry!=0){
            int x = l1==null?0:l1.val;
            int y = l2==null?0:l2.val;
            int total = x+y+carry;
            curr.next=new ListNode(total%10);
            curr=curr.next;
            carry=total/10;
            if(l1!=null)l1=l1.next;
            if(l2!=null)l2=l2.next;
        }
        return head.next;
    }
}
