/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if(head == null || head.next == null)
            return false; 

        HashSet<ListNode> nodes = new HashSet<ListNode>();
        ListNode current = head;
        while(current != null)
        {
            if(!nodes.Contains(current))
            {
                nodes.Add(current);
                current = current.next; 
            }
            else 
                return true; 
        }

        return false; 
            
    }
}