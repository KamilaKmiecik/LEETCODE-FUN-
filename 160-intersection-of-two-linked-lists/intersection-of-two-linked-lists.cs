/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
       //pointers to headA and headB
        var currentA = headA; 
        var currentB = headB; 

        //no intersection while they're not equal
        while(currentA != currentB)
        {

            currentA =  currentA != null ? currentA.next : headA; 
            currentB = currentB !=  null ? currentB.next : headB; 
        }

        return currentA; 
    }
}