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
        ListNode start = new ListNode(0);
        ListNode current = start;
        int carry = 0;

        while (l1 != null | l2 != null | carry != 0){
            int sum = carry;

            if (l1 != null){
                sum += l1.val;
                l1 = l1.next;
            }

            if (l2 != null){
                sum += l2.val;
                l2 = l2.next;
            }

            carry = sum / 10;

            if (sum >= 10){
                sum -= 10;
            }

            current.next = new ListNode(sum);
            current = current.next;
        }

        return start.next;
    
        
    }

    // public ListNode ReverseList(ListNode list){
    //     ListNode reversed = null;

    //     while (list != null)
    //     {
    //         ListNode temp = list;   // Pop()
    //         list = list.next;

    //         temp.next = reversed;   // Push()
    //         reversed = temp;
    //     }

    //     return reversed;
    // }
}