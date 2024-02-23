namespace _104._Maximum_Depth_of_Binary_Tree
{
    internal static class Helper
    {
        private static int _depth = 0;

        private static void GetChild(TreeNode node, int level)
        {
            if (node == null)
                return;

            _depth = Math.Max(_depth, level + 1);
            if (node.left != null)
            {
                GetChild(node.left, level + 1);
            }
            if (node.right != null)
            {
                GetChild(node.right, level + 1);
            }
            return;
        }

        public static int MaxDepth(TreeNode root)
        {
            GetChild(root, 0);
            return _depth;
        }
    }
}
