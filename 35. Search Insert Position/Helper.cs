namespace _35._Search_Insert_Position
{
    internal static class Helper
    {
        internal static int SearchInsert(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            var midle = (int) Math.Ceiling((decimal)(left + right + 1) / 2);

            if (nums[left] > target)
            {
                return 0;
            }
            else if (nums[right] < target)
            {
                return nums.Length;
            }
            else if (nums[left] == target)
            {
                return left;
            }
            else if (nums[right] == target)
            {
                return right;
            }
            else if (nums.Length == 2)
            {
                return 1;
            }

            while (left < right)
            {
                if ((right - left) > 1)
                {
                    midle = (int)Math.Ceiling((decimal)(left + right) / 2);
                }
                else
                {
                    if (nums[left] < target)
                    {
                        midle = right;
                    }
                    else if (nums[left] > target)
                    {
                        midle = left;
                    }
                    else
                    {
                        return midle;
                    }
                    return midle;
                }
                
                if (nums[midle] < target)
                {
                    left = midle;
                }
                else if (nums[midle] > target)
                {
                    right = midle;
                }
                else
                {
                    return midle;
                }
            }

            return midle;
        }
    }
}
