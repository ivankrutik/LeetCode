namespace _1608._Special_Array_With_X_Elements_Greater_Than_or_Equal_X
{
    internal static class Helper
    {
        public static int SpecialArray(int[] nums)
        {
            nums = nums.Order().ToArray();
            var r = -1;

            for (var i = nums.Length; i > 0; i--)
            {
                var isExist = true;
                for (var j = 0; j < i; j++)
                {
                    if (nums[nums.Length - j - 1] < i)
                    {
                        isExist = false;
                        break;
                    }
                }
                if (isExist &&  (nums.Length - i -1 < 0 || nums[nums.Length - i - 1] < i))
                {
                    r = i;
                    break;
                }
            }

            return r;
        }
    }
}
