namespace _1._Two_Sum
{
    public static class Helper
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if ((nums[i] + nums[j]) == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
