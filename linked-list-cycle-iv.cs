public class Solution {
    public static ListNode RemoveCycle(ListNode head) {
        if (head == null || head.next == null)
            return head;

        ListNode slow = head;
        ListNode fast = head;

        // Step 1: Detect cycle
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
                break;
        }

        // Step 2: If no cycle, return head
        if (fast == null || fast.next == null)
            return head;

        // Step 3: Find start of cycle
        slow = head;
        if (slow == fast) {
            // special case: cycle starts at head
            while (fast.next != slow) {
                fast = fast.next;
            }
            fast.next = null;
            return head;
        }

        // Normal case
        while (slow.next != fast.next) {
            slow = slow.next;
            fast = fast.next;
        }

        // Step 4: Break the cycle
        fast.next = null;
        return head;
    }
}
