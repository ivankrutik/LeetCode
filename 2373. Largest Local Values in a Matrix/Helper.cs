namespace _2373._Largest_Local_Values_in_a_Matrix
{
    internal static class Helper
    {
        private static int getLocalMax(int[][] grid, int i, int j)
        {
            var res = grid[i][j];
            res = Math.Max(res, grid[i - 1][j]);
            res = Math.Max(res, grid[i + 1][j]);
            res = Math.Max(res, grid[i][j + 1]);
            res = Math.Max(res, grid[i][j - 1]);
            res = Math.Max(res, grid[i - 1][j - 1]);
            res = Math.Max(res, grid[i - 1][j + 1]);
            res = Math.Max(res, grid[i + 1][j - 1]);
            res = Math.Max(res, grid[i + 1][j + 1]);

            return res;
        }

        public static int[][] LargestLocal(int[][] grid)
        {
            var res = new int[grid.Length - 2][];

            for (var i = 1; i < grid.Length - 1; i++)
            {
                res[i - 1] = new int[grid.Length - 2];
                for (var j = 1; j < grid.Length - 1; j++)
                {
                    res[i - 1][j - 1] = getLocalMax(grid, i, j);
                }
            }

            return res;
        }
    }
}
