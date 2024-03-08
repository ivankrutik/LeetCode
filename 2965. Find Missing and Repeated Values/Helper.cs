namespace _2965._Find_Missing_and_Repeated_Values
{
    internal static class Helper
    {
        public static int[] FindMissingAndRepeatedValues(int[][] grid)
        {
            var count = grid.Length * grid[0].Length;
            HashSet<int> result = new HashSet<int>();
            HashSet<int> resultNotExists = new HashSet<int>();
            for (int i = 1; i <= count; i++)
            {
                resultNotExists.Add(i);
            }
            var res = new int[2];

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    resultNotExists.Remove(grid[i][j]);
                    if (!result.Contains(grid[i][j]))
                    {
                        result.Add(grid[i][j]);
                    }
                    else
                    {
                        res[0] = grid[i][j];
                    }
                }
            }
            res[1] = resultNotExists.FirstOrDefault();

            return res;
        }
    }
}
