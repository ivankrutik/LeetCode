namespace _1._Two_Sum
{
    using System.Collections.Generic;

    public static class Helper
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var sortedList = new List<Tuple<int, int>>();

            for (var i = 0; i < nums.Count(); i++)
            {
                sortedList.Add(new Tuple<int, int>(nums[i], i));
            }

            sortedList.Sort();

            for (int i = 0; i < sortedList.Count; i++)
            {
                for (int j = 0; j < sortedList.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (sortedList[i].Item1 + sortedList[j].Item1 > target)
                    {
                        break;
                    }
                    if (sortedList[i].Item1 + sortedList[j].Item1 == target)
                    {
                        return new int[2] { sortedList[i].Item2, sortedList[j].Item2 };
                    }
                }
            }
            return null;
        }
    }
}
