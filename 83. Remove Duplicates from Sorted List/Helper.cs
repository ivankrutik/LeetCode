namespace _83._Remove_Duplicates_from_Sorted_List
{
    public static class Helper
    {
        static ListNode? GetNextLn(ListNode node, int val)
        {
            if (node.next == null)
                return null;

            if (node.next.val == val)
            {
                return GetNextLn(node.next, val);
            }
            return node.next;
        }

        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode? ndCurrent = head;

            while (ndCurrent != null && ndCurrent.next != null)
            {
                ndCurrent.next = GetNextLn(ndCurrent, ndCurrent.val);
                ndCurrent = ndCurrent.next;
            }
            return head;
        }
    }
}
