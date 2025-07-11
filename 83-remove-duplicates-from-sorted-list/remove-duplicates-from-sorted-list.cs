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
        
public ListNode DeleteDuplicates(ListNode head)
{
        var removedHead = new ListNode(-1111);
    ListNode current = null;
    current = removedHead;

    while (head != null)
    {
        if (head.val != current.val)
        {
            current.next = new ListNode(head.val);
            current = current.next;
        }
        head = head.next;
    }

    return removedHead.next;
}
    }
