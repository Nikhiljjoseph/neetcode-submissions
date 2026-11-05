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
        ListNode finalHead = new ListNode();
        ListNode final = finalHead;
        while(list1!=null && list2!=null){
            if(list1.val<=list2.val){
                final.next=list1;
                list1=list1.next;
            }
            else{
                final.next=list2;
                list2=list2.next;
            }
            final=final.next;
        }
        if(list1 != null)
            final.next=list1;
        if(list2 != null)
            final.next=list2;
        return finalHead.next;
    }
}