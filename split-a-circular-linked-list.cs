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
    public ListNode[] SplitCircularLinkedList(ListNode list) {
        if (list == null || list.next == list)
            return new ListNode[] { list, null };

        ListNode slow = list;
        ListNode fast = list;

        // Use Floyd's slow-fast to find mid-point
        while (fast.next != list && fast.next.next != list)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // For even-length lists, advance fast to the last node
        if (fast.next.next == list)
        {
            fast = fast.next;
        }

        // Split into two circular lists
        ListNode head1 = list;
        ListNode head2 = slow.next;

        slow.next = head1;
        fast.next = head2;

        return new ListNode[] { head1, head2 };
    }
}