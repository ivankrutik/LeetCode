namespace _2962._Count_Subarrays_Where_Max_Element_Appears_at_Least_K_Times
{
    internal static class Helper
    {
        public static long CountSubarrays(int[] nums, int k)
        {
            Dictionary<long, long> dict = new Dictionary<long, long>();
            long max = 0;

            for (long i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] += 1;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            long count = 0;
            long maxElementCount = 0;
            long left = 0;
            long right = 0;

            while (right < nums.Length)
            {
                if (nums[right] == max)
                {
                    maxElementCount++;
                }

                while (maxElementCount == k)
                {
                    count = count + (nums.Length - right);
                    if (nums[left] == max)
                    {
                        maxElementCount--;
                    }
                    left++;
                }
                right++;
            }

            return count;
        }
    }
}
