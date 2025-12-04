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
       
        HashSet<ListNode> seen = new HashSet<ListNode>();

        ListNode current = head;

        while (current != null){

            if (seen.Contains(current)){
                return true;   
            }
                    
            seen.Add(current);
            current = current.next;
        }

        return false;
    }
}