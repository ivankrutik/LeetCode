namespace _448._Find_All_Numbers_Disappeared_in_an_Array
{
    internal static class Helper
    {
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                while (true)
                {
                    var j = nums[i] - 1;
                    if (nums[i] == nums[j])
                    {
                        break;
                    }
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                }
            }
            var res = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    res.Add(i+1);
                }
            }
            return res;
        }
    }
}
