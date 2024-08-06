namespace EasyProblems;

//https://leetcode.com/problems/remove-duplicates-from-sorted-list/
public class Problem83
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        var current = head;

        while (current != null)
        {
            while (current.next != null && current.next.val == current.val)
            {
                current.next = current.next.next;
            }

            current = current.next;
        }

        return head;

    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}