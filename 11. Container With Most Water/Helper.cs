namespace _11._Container_With_Most_Water
{
    internal static class Helper
    {
        public static int MaxArea(int[] height)
        {
            int l = 0;
            int r = height.Length - 1;
            int area = 0;

            while (l < r)
            {
                area = Math.Max((r - l) * Math.Min(height[r], height[l]), area);
                if (height[l] > height[r])
                    r = r - 1;
                else 
                    l = l + 1;
            }
            return area;
        }
    }
}
