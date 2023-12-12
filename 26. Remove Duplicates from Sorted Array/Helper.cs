namespace _26._Remove_Duplicates_from_Sorted_Array
{
    public static class Helper
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if ((i < nums.Length - 1) && nums[i] == nums[i + 1])
                {
                    continue;
                }

                nums[j++] = nums[i];
            }
            return j;
        }
    }
}
