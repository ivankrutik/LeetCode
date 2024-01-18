namespace _136._Single_Number
{
    internal static class Helper
    {
        public static int SingleNumber(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < nums.Length; i++) 
            {
                res ^= nums[i];
            }
            return res;
        }
    }
}
