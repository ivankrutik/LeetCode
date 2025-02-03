namespace _3105._Longest_Strictly_Increasing_or_Strictly_Decreasing_Subarray
{
    public static class Helper
    {
        public static int LongestMonotonicSubarray(int[] nums)
        {
            int countMinus = 1;
            int countPlus = 1;

            int tempMinus = 1;
            int tempPlus = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] > nums[i])
                {
                    tempMinus++;
                    countMinus = Math.Max(countMinus, tempMinus);
                }
                else
                    tempMinus = 1;

                if (nums[i - 1] < nums[i])
                {
                    tempPlus++;
                    countPlus = Math.Max(countPlus, tempPlus);
                }
                else
                    tempPlus = 1;
            }

            return Math.Max(countPlus, countMinus);
        }
    }
}
