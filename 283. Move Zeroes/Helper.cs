namespace _283._Move_Zeroes
{
    internal static class Helper
    {
        public static int[] MoveZeroes(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    for (var j = i; j < nums.Length; j++)
                    {
                        if (nums[j] != 0)
                        {                            
                            nums[i] = nums[j];
                            nums[j] = 0;
                            break;
                        }
                    }
                }
            }

            return nums;
        }
    }
}
