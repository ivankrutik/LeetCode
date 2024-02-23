namespace _111._Minimum_Depth_of_Binary_Tree
{
    internal static class Helper
    {
        private static int minDepth = int.MaxValue;

        private static void getMinDepth(TreeNode? node, int level)
        {
            if (node.left == null && node.right == null)
            {
                minDepth = Math.Min(minDepth, level + 1);
                return;
            }

            if (node.left != null)
            {
                getMinDepth(node.left, level + 1);
            }
            if (node.right != null)
            {
                getMinDepth(node.right, level + 1);
            }
        }

        public static int MinDepth(TreeNode root)
        {
            if (root == null) { return 0; }
            getMinDepth(root, 0);
            return minDepth;
        }
    }
}
