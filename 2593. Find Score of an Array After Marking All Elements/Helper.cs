namespace _2593._Find_Score_of_an_Array_After_Marking_All_Elements
{
    internal static class Helper
    {
        public static long FindScore(int[] nums)
        {
            long score = 0;

            var dict = new Dictionary<int, int>();
            int i = 0;
            foreach (var num in nums)
            {
                dict.Add(i++, num);
            }
            dict = dict.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary();

            foreach (var d in dict)
            {

                if (nums[d.Key] != 0)
                {
                    score += nums[d.Key];
                    nums[d.Key] = 0;
                    if (d.Key + 1 < nums.Length)
                        nums[d.Key + 1] = 0;
                    if (d.Key - 1 >= 0)
                        nums[d.Key - 1] = 0;
                }
            }

            return score;
        }
    }
}
