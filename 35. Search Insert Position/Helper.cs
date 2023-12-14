namespace _35._Search_Insert_Position
{
    internal static class Helper
    {
        internal static int SearchInsert(int[] nums, int target)
        {
            var i = Array.IndexOf(nums, target);
            if (i != -1)
                return i;

            i = 0;

            foreach (var item in nums)
            {
                if (target > item)
                {
                    i++;
                }
                else
                {
                    return i;
                }
            }

            return i;
        }
    }
}
