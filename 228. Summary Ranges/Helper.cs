
namespace _228._Summary_Ranges
{
    internal static class Helper
    {
        public static IList<string> SummaryRanges(int[] nums)
        {
            var res = new List<string>();
            if (nums.Length == 0)
                return res;
            if (nums.Length == 1)
            {
                res.Add(nums[0].ToString());
                return res;
            }


            int prev = nums[0];
            int startInt = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (prev + 1 == nums[i] && (i + 1 < nums.Length))
                {
                    prev = nums[i];
                    continue;
                }
                else
                {
                    bool IsLast = false;
                    if (i + 1 == nums.Length)
                    {
                        if (prev + 1 == nums[i])
                            prev = nums[i];
                        else
                            IsLast = true;
                    }

                    if (startInt == prev)
                    {
                        res.Add(startInt.ToString());
                    }
                    else
                    {
                        res.Add(startInt.ToString() + "->" + prev.ToString());
                    }

                    if (IsLast)
                        res.Add(nums[i].ToString());

                    prev = nums[i];
                    startInt = nums[i];
                }
            }
            return res;
        }
    }
}