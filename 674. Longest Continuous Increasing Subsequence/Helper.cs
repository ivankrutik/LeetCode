namespace _674._Longest_Continuous_Increasing_Subsequence
{
    internal static class Helper
    {
        public static int FindLengthOfLCIS(int[] nums)
        {
            int res = 1;
            int total = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    res = res + 1;
                    total = Math.Max(res, total);
                }
                else
                    res = 1;
            }
            return total;
        }
    }
}
