namespace _94._Binary_Tree_Inorder_Traversal
{
    internal static class Helper
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            IList<int> res = new List<int>();
            var curr = root;

            while (true)
            {
                if (curr != null)
                {
                    s.Push(curr);
                    curr = curr.left;
                }
                else
                {
                    if (!s.Any())
                        break;

                    curr = s.Peek();
                    res.Add(curr.val);
                    s.Pop();
                    curr = curr.right;
                }
            }

            return res;
        }
    }
}
