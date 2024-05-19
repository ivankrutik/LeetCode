namespace _3142._Check_if_Grid_Satisfies_Conditions
{
    internal static class Helper
    {
        public static bool SatisfiesConditions(int[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (((i + 1) < grid.Length && grid[i][j] != grid[i + 1][j]) || ((j + 1) < grid[i].Length && grid[i][j] == grid[i][j + 1]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
