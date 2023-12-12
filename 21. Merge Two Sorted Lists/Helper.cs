namespace _21._Merge_Two_Sorted_Lists
{
    internal static class Helper
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode res = new ListNode();
            ListNode temp = new ListNode();
            bool isFirst = true;

            if ((list1 == null || list1.val == null) && (list2 != null && list2.val != null))
            {
                return list2;
            }
            if ((list2 == null || list2.val == null) && (list1 != null && list1.val != null))
            {
                return list1;
            }
            if ((list2 == null || list2.val == null) && (list1 == null || list1.val == null))
            {
                return null;
            }

            while (true)
            {
                if (list1.val <= list2.val)
                {
                    if (isFirst)
                    {
                        res = new ListNode(list1.val);
                        temp = res;
                    }
                    else
                    {
                        temp.next = new ListNode();
                        temp = temp.next;
                        temp.val = list1.val;
                    }

                    if (list1.next != null)
                    {
                        list1 = list1.next;
                    }
                    else
                    {
                        temp.next = list2;
                        break;
                    }
                }
                else
                {
                    if (isFirst)
                    {
                        res = new ListNode(list2.val);
                        temp = res;
                    }
                    else
                    {
                        temp.next = new ListNode();
                        temp = temp.next;
                        temp.val = list2.val;
                    }

                    if (list2.next != null)
                    {
                        list2 = list2.next;
                    }
                    else
                    {
                        temp.next = list1;
                        break;
                    }
                }

                isFirst = false;
            }


            return res;
        }
    }
}
