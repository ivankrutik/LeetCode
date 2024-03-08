namespace _3005._Count_Elements_With_Maximum_Frequency
{
    internal static class Helper
    {
        public static int MaxFrequencyElements(int[] nums)
        {
            var res = nums.GroupBy(x => x).Select(group => new { Value = group.Key, Count = group.Count() });
            var r = res.Where(w=>w.Count == res.Max(m=>m.Count)).Sum(s=>s.Count);
            return r;
        }
    }
}
