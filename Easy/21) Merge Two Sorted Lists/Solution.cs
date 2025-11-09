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
public class Solution 
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        // Temporarily store all nodes in an array
        // Sort the array
        // create a new LinkedList
        
        // List<int> node_list = new List<int>();

        ListNode head = new ListNode();
        ListNode current = head;

        while (list1 != null && list2 != null){
            if (list1.val < list2.val){
                current.next = list1;
                list1 = list1.next;
            }

            else{
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }

        // One of the lists will be null by this point so you need to add the last node
        current.next = list1 ?? list2;

        return head.next;

        // while (list1 != null)
        // {
        //     node_list.Add(list1.val);
        //     list1 = list1.next;
        // }

        // while (list2 != null)
        // {
        //     node_list.Add(list2.val);
        //     list2 = list2.next;
        // }

       
        // node_list.Sort();

        // // Make a new Linked List
        // if (node_list.Count == 0) return null;
            
        // ListNode head = new ListNode(node_list[0]);
        // ListNode current = head;

        // for (int i = 1; i < node_list.Count; i++)
        // {
        //     current.next = new ListNode(node_list[i]);
        //     current = current.next;
        // }

        // return head;
        
         
    }
}