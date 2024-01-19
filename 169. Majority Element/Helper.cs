namespace _169._Majority_Element
{
    internal static class Helper
    {
        public static int MajorityElement(int[] nums)
        {
            var res = nums.GroupBy(x => x).
                Select(z => new { ValueData = z, Count = z.Count() }).
                FirstOrDefault(x => x.Count == nums.GroupBy(x => x).
                Select(z => new { ValueData = z, Count = z.Count() }).
                Max(z => z.Count)).ValueData.FirstOrDefault();
            return res;
        }
    }
}
