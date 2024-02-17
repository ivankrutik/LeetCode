namespace _2971._Find_Polygon_With_the_Largest_Perimeter
{
    internal static class Helper
    {
        public static long LargestPerimeter(int[] nums)
        {
            var res = new List<long>();
            bool isExistFirst = false;
            int? stopIndex = 0;

            nums = nums.OrderBy(x => x).ToArray();
            long summ = nums[0] + nums[1];

            for (int i = 2; i < nums.Length; i++)
            {
                if (summ > nums[i])
                {
                    if (stopIndex != null)
                    {
                        if (stopIndex == 0)
                        {
                            isExistFirst = true;
                        }

                        for (int j = (int)stopIndex; j < i; j++)
                        {
                            res.Add(nums[j]);
                        }
                    }
                    stopIndex = null;
                    res.Add(nums[i]);
                }
                else
                {
                    if (stopIndex == null)
                    {
                        if (i == 2 && !isExistFirst)
                        {
                            stopIndex = 0;
                            isExistFirst = true;
                        }
                        else if (i == 3 && !isExistFirst)
                        {
                            stopIndex = 1;
                            isExistFirst = true;
                        }
                        else
                        {
                            stopIndex = i;
                        }
                    }
                }
                summ = summ + nums[i];
            }
            var summ1 = res.Sum(x => x);
            return summ1 != 0 ? summ1 : -1;
        }
    }
}
