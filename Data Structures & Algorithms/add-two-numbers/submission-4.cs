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
        int carry = 0;
        ListNode first = l1;
        ListNode second = l2;
        ListNode dummy = new ListNode();
        while(first != null && second != null){
            ListNode sum = new ListNode();
            sum.next = dummy.next;
            dummy.next=sum;
            int val = first.val+second.val+carry;
            sum.val = val%10;
            carry = val/10;
            first=first.next;
            second=second.next;
        }
        while(first != null){
            ListNode sum = new ListNode();
            sum.next = dummy.next;
            dummy.next=sum;
            int val = first.val+carry;
            sum.val = val%10;
            carry = val/10;
            first=first.next;
        }
        while(second != null){
            ListNode sum = new ListNode();
            sum.next = dummy.next;
            dummy.next=sum;
            int val = second.val+carry;
            sum.val = val%10;
            carry = val/10;
            second=second.next;
        }
        if(carry != 0){
            ListNode sum = new ListNode();
            sum.next = dummy.next;
            dummy.next=sum;
            sum.val = carry;
        }

        //reverse linkedlist from dummy.next to null
            ListNode prev=null;
            ListNode curr = dummy.next;
            while(curr != null){
                ListNode temp = curr.next;
                curr.next=prev;
                prev=curr;
                curr=temp;
            }
        return prev;
    }
}
