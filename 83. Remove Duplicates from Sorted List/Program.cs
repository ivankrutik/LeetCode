/*
 
Given the head of a sorted linked list, delete all duplicates such that each element appears only once. 
Return the linked list sorted as well.

 

Example 1:


Input: head = [1,1,2]
Output: [1,2]
Example 2:


Input: head = [1,1,2,3,3]
Output: [1,2,3]
 

Constraints:

The number of nodes in the list is in the range [0, 300].
-100 <= Node.val <= 100
The list is guaranteed to be sorted in ascending order.
 
 */
using _83._Remove_Duplicates_from_Sorted_List;

static ListNode fillLN(ListNode ln, int val, int nextVal)
{
    ln.val = val;
    var lnNext = new ListNode(nextVal);
    ln.next = lnNext;
    return lnNext;
}

var arr = new int[] { 1, 1, 2, 3, 3 };

var lnFirst = new ListNode();
var ln = lnFirst;

for (int i = 0; i < arr.Length - 1; i++)
{
    ln = fillLN(ln, arr[i], arr[i + 1]);
}

var res = Helper.DeleteDuplicates(lnFirst);

while (res != null)
{
    Console.WriteLine(res.val);
    res = res.next;
}

