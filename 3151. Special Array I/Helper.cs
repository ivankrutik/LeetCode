namespace _3151._Special_Array_I
{
    internal static class Helper
    {
        public static bool IsArraySpecial(int[] nums)
        {
            bool isEven = nums[0] % 2 == 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if ((isEven && nums[i] % 2 != 0) || (!isEven && nums[i] % 2 == 0))
                {
                    isEven = nums[i] % 2 == 0;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
