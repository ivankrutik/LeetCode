namespace _1791._Find_Center_of_Star_Graph
{
    internal static class Helper
    {
        public static int FindCenter(int[][] edges)
        {
            var dict = new List<int>();

            dict.Add(edges[0][0]);
            dict.Add(edges[0][1]);

            return dict.Contains(edges[1][0]) ? edges[1][0] : edges[1][1];
        }
    }
}
