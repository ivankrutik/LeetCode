namespace _2418._Sort_the_People
{
    internal static class Helper
    {
        public static string[] SortPeople(string[] names, int[] heights)
        {
            var dict = new Dictionary<int, string>();
            for (int i = 0; i < names.Length; i++) 
            {
                dict.Add(heights[i], names[i]);
            }
            return dict.OrderByDescending(x=>x.Key).Select(x=>x.Value).ToArray();
        }
    }
}
