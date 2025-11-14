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
    public ListNode DeleteDuplicates(ListNode head) {

        if (head == null){
            return null;
        }

        HashSet<int> seen = new HashSet<int>();
        ListNode node = new ListNode(0);
        ListNode tail = node;
        

        ListNode current = head;
        while(current!= null){
            if (!seen.Contains(current.val)){
                seen.Add(current.val);
                tail.next = new ListNode(current.val);
                tail = tail.next;
                
            
            }

            current = current.next;

            
        }

        return node.next;
        
        
    }
}