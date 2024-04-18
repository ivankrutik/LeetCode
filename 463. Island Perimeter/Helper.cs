namespace _463._Island_Perimeter
{
    internal static class Helper
    {
        private static int getBorder(int i, int j, int[][] grid)
        {
            int r = 0;
            if (i - 1 < 0 || grid[i - 1][j] != 1)
            {
                r++;
            }
            if (i + 1 >= grid.Length || grid[i + 1][j] != 1)
            {
                r++;
            }
            if (j - 1 < 0 || grid[i][j - 1] != 1)
            {
                r++;
            }
            if (j + 1 >= grid[i].Length || grid[i][j + 1] != 1)
            {
                r++;
            }
            return r;
        }

        public static int IslandPerimeter(int[][] grid)
        {
            int r = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        r = r + getBorder(i, j, grid);
                    }
                }
            }

            return r;
        }
    }
}
