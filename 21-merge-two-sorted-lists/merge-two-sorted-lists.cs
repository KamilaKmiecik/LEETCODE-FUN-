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

     private static ListNode AddNode(ref ListNode list1, ListNode current)
     {
         current.next = new ListNode(list1.val);
         current = current.next;
         list1 = list1.next;
         return current;
     }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {

        //head is a pointer to the linkedlist, current only shows the CURRENT element
        ListNode head = new ListNode(0);
        ListNode current = null;
        current = head;

 while (list1 != null || list2 != null)
 {
     if (list1 != null && list2 != null)
     {
         if (list1.val < list2.val)
             current = AddNode(ref list1,current);
         else
             current = AddNode(ref list2, current);
     }
     else if (list1 != null)
             current = AddNode(ref list1, current);
     else if (list2 != null)
             current = AddNode(ref list2, current);
 
 }

//getting rid of the zero at the beginning
 head = head.next;

 return head; 
    }
}