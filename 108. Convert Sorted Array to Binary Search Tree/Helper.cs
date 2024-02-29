namespace _108._Convert_Sorted_Array_to_Binary_Search_Tree
{
    internal static class Helper
    {
        private static TreeNode? GetNode(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }
            var midle = (left+right) / 2;
            var res = new TreeNode(nums[midle]);
            res.left = GetNode(nums, left, midle - 1);
            res.right = GetNode(nums, midle + 1, right);
            return res;
        }


        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return GetNode(nums, 0, nums.Length-1);
        }
    }
}
