
namespace _1038._Binary_Search_Tree_to_Greater_Sum_Tree
{
    internal static class Helper
    {
        public static TreeNode BstToGst(TreeNode root)
        {
            int greaterSum = 0;
            int prev = 0;
            int count = 0;

            convert(ref root, ref greaterSum, ref prev, ref count);
            return root;
        }

        private static void convert(ref TreeNode node, ref int greaterSum, ref int prev, ref int count)
        {
            if (node == null)
            {
                return;
            }
            convert(ref node.right, ref greaterSum, ref prev, ref count);
            if (node.val == prev)
            {
                count++;
            }
            else
            {
                greaterSum += prev * count;
                count = 1;
                prev = node.val;
            };
            node.val += greaterSum;
            convert(ref node.left, ref greaterSum, ref prev, ref count);
        }
    }
}
