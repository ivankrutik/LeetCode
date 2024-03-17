namespace _525._Contiguous_Array
{
    internal static class Helper
    {
        public static int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, -1);

            int max = 0;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count--;
                }
                else
                {
                    count++;
                }

                if (dict.ContainsKey(count))
                {
                    max = Math.Max(max, i - dict[count]);
                }
                else
                {
                    dict.Add(count, i);
                }
            }
            return max;
        }
    }
}
