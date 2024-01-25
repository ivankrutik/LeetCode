namespace _217._Contains_Duplicate
{
    internal static class Helper
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> keyValuePairs = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (keyValuePairs.Contains(nums[i]))
                    return true;
                else
                    keyValuePairs.Add(nums[i]);
            }
            return false;
        }
    }
}
