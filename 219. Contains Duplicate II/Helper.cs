namespace _219._Contains_Duplicate_II
{
    internal static class Helper
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (keyValuePairs.ContainsValue(nums[i]))
                {
                    if ((i - keyValuePairs.Where(x=>x.Value == nums[i]).FirstOrDefault().Key) <= k)
                    {
                        return true;
                    }
                }
                if (keyValuePairs.Count <= k)
                {
                    keyValuePairs.Add(i, nums[i]);
                }
                else
                {
                    keyValuePairs.Remove(i - k - 1);
                    keyValuePairs.Add(i, nums[i]);
                }
            }
            return false;
        }
    }
}
