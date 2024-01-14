namespace _100._Same_Tree
{
    internal static class Helper
    {
        private static bool IsNotEqual;

        private static void getData(TreeNode p, TreeNode q)
        {


            if (p.val != q.val ||
                (p.left != null && q.left == null) ||
                (p.left == null && q.left != null) ||
                (p.right != null && q.right == null) ||
                (p.right == null && q.right != null))
            {
                IsNotEqual = false;
                return;
            }

            if (q.left != null && p.left != null)
            {
                getData(p.left, q.left);
            }
            if (q.right != null && p.right != null)
            {
                getData(p.right, q.right);
            }
        }

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if (p != null && q == null || p == null && q != null)
            {
                return false;
            }

            IsNotEqual = true;
            getData(p, q);
            return IsNotEqual;
        }
    }
}
