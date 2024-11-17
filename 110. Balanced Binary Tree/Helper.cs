namespace _110._Balanced_Binary_Tree
{
    public static class Helper
    {
        private static int CalculateHeight(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            // Recursively find the height of the left and right subtrees.
            int leftHeight = CalculateHeight(node.left);
            int rightHeight = CalculateHeight(node.right);

            // Check if left or right subtree is unbalanced or if they differ in height by more than 1.
            if (leftHeight == -1 || rightHeight == -1 || Math.Abs(leftHeight - rightHeight) > 1)
            {
                return -1; // Tree is not balanced.
            }

            // Current node height is max of left and right subtree heights plus 1 (for the current node).
            return 1 + Math.Max(leftHeight, rightHeight);
        }

        public static bool IsBalanced(TreeNode root)
        {
            return CalculateHeight(root) >= 0;
        }
    }
}
