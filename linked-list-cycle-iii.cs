// The first input of the test case is an array of values representing a linked list. 
// The second input is the index where the tail connects to form a cycle (or −1 if there's no cycle). 
// This index is used only to construct the linked list and is not passed to the function.

// Definition for a Linked List node
// class ListNode
// {
//     public int val;
//     public ListNode next;

//     // Constructor
//     public ListNode(int val = 0, ListNode next = null)
//     {
//         this.val = val;
//         this.next = next;
//     }
// }

using System;
using System.Collections.Generic;

public class Solution {
    public static int CountCycleLength(ListNode head) {

        ListNode slow = head;
        ListNode fast = head;
        
        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            
            if (slow == fast)
                break;
        }
        
        // determine cycle or not
        if(fast != slow)
        {
            return 0;
        }
        
        // get the start of the cycle
        slow = head;
        while(slow != fast)
        {
            slow = slow.next;
            fast = fast.next;
        }
        
        ListNode start = slow.next;
        int count = 1;
        
        while(start != slow)
        {
            start = start.next;
            count++;
        }
        
        return count;
    }
}