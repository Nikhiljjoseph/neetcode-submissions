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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode a = list2;
        ListNode b = list1;
        ListNode final = null;
        ListNode finalHead = null;
        if(a==null) return list1;
        if(b==null) return list2;
        if(a.val <= b.val){
            final = a;
            a=a.next;
        }
        else{
            final=b;
            b=b.next;
        }
        finalHead=final;
        while(a!=null && b!=null){
            if(a.val<=b.val){
                final.next=a;
                final=final.next;
                a=a.next;
            }
            else{
                final.next=b;
                final=final.next;
                b=b.next;
            }
        }
        while(a!=null){
            final.next=a;
            final=final.next;
            a=a.next;
        }
        while(b!=null){
            final.next=b;
            final=final.next;
            b=b.next;
        }
        return finalHead;
    }
}