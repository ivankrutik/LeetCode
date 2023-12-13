namespace _27._Remove_Element
{
    internal static class Helper
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int position = 0;
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    position++;
                }
                else
                {
                    j = position+1;
                    while (j < nums.Length)
                    {
                        if (nums[j] != val)
                        {
                            nums[i] = nums[j];
                            nums[j] = val;

                            position++;
                            break;
                        }
                        j++;
                    }
                }
            }

            return position;
        }
    }
}
