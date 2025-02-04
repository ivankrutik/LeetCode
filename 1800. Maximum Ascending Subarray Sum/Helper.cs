namespace _1800._Maximum_Ascending_Subarray_Sum
{
    public static class Helper
    {
        public static int MaxAscendingSum(int[] nums)
        {
            int sumPlus = nums[0];
            int tempPlus = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] < nums[i])
                {
                    tempPlus = tempPlus + nums[i];
                }
                else
                    tempPlus = nums[i];

                sumPlus = Math.Max(sumPlus, tempPlus);
            }

            return sumPlus;
        }
    }
}
