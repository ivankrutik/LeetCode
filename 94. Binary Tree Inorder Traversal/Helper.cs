namespace _94._Binary_Tree_Inorder_Traversal
{
    internal static class Helper
    {
        private static void getData(TreeNode node, ref IList<int> res)
        {           
            if (node.left != null)
            {
                getData(node.left, ref res);
            }
            res.Add(node.val);
            if (node.right != null)
            {
                getData(node.right, ref res);
            }
        }

        public static IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> res = new List<int>();
            if (root == null)
                return res;

            getData(root, ref res);

            return res;
        }
    }
}
