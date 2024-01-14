namespace _101._Symmetric_Tree
{
    internal static class Helper
    {
        private static bool IsSymmetricTree;

        private static void getData(TreeNode p, TreeNode q)
        {
            if (q == null && p == null)
            {
                return;
            }
            if (p != null && q == null || p == null && q != null)
            {
                IsSymmetricTree = false;
                return;
            }
            if (p.val != q.val)
            {
                IsSymmetricTree = false;
                return;
            }

            getData(p.left, q.right);
            getData(p.right, q.left);
        }

        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            IsSymmetricTree = true;
            getData(root.left, root.right);
            return IsSymmetricTree;
        }

    }
}
