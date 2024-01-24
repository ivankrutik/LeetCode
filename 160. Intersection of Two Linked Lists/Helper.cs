namespace _160._Intersection_of_Two_Linked_Lists
{
    internal static class Helper
    {
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }

            var nodeA = headA;
            var nodeB = headB;

            while (true)
            {
                if (nodeA == nodeB)
                {
                    return nodeA;
                }
                nodeA = nodeA.next;
                nodeB = nodeB.next;
                if (nodeA == nodeB)
                {
                    return nodeA;
                }

                if (nodeA == null )
                {
                    nodeA = headB;
                    continue;
                }
                if (nodeB == null )
                {
                    nodeB = headA;
                    continue;
                }
               
            }
        }
    }
}
