namespace _1051._Height_Checker
{
    internal static class Helper
    {
        public static int HeightChecker(int[] heights)
        {
            var count = 0;
            var arr2 = heights.OrderBy(x => x).ToArray();
            for (var i = 0; i < heights.Length; i++)
            {
                if (heights[i] != arr2[i])
                { 
                    count++;
                }
            }
            return count;
        }
    }
}
