namespace _206._Reverse_Linked_List
{
    using System.Collections.Generic;

    internal static class Helper
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
                  }
            Stack<ListNode> stack = new Stack<ListNode>();
            while (true)
            {
                if (head == null)
                {
                    break;
                }
                stack.Push(head);
                head = head.next;
            }
            head = stack.Pop();
            var temp = head;
            while (true)
            {
                if (!stack.Any())
                {
                    temp.next = null;
                    break;
                }
                temp.next = stack.Pop();
                temp = temp.next;
            }

            return head;
        }
    }
}
