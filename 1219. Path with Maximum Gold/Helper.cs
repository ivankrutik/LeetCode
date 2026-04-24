namespace _1219._Path_with_Maximum_Gold
{
    public class Route
    {
        public int Gold { get; set; }

        public bool WasLocated { get; set; }
    }


    internal static class Helper
    {
        private static Route[][] FillMatrix(int[][] grid)
        {
            var matrix = new Route[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                matrix[i] = new Route[grid[i].Length];
                for (int j = 0; j < grid[i].Length; j++)
                {
                    matrix[i][j] = new Route();
                    matrix[i][j].Gold = grid[i][j];
                    matrix[i][j].WasLocated = false;
                }
            }
            return matrix;
        }

        private static Route[][] CopyMatrix(Route[][] grid)
        {
            var matrix = new Route[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                matrix[i] = new Route[grid[i].Length];
                for (int j = 0; j < grid[i].Length; j++)
                {
                    matrix[i][j] = new Route();
                    matrix[i][j].Gold = grid[i][j].Gold;
                    matrix[i][j].WasLocated = grid[i][j].WasLocated;
                }
            }
            return matrix;
        }

        private static void ClearRoute(ref Route[][] route)
        {
            foreach (var i in route)
            {
                foreach (var r in i)
                {
                    r.WasLocated = false;
                }
            }
        }

        private static int TotalSumm = 0;

        private static void Run(Route[][] matrix, int i, int j, int summ)
        {
            matrix[i][j].WasLocated = true;

            summ = summ + matrix[i][j].Gold;
            TotalSumm = Math.Max(TotalSumm, summ);

            // step right
            if (i + 1 < matrix.Length && matrix[i + 1][j].Gold != 0 && !matrix[i + 1][j].WasLocated)
            {

                Run(CopyMatrix(matrix), i + 1, j, summ);
            }

            // step left
            if (i - 1 >= 0 && matrix[i - 1][j].Gold != 0 && !matrix[i - 1][j].WasLocated)
            {
                Run(CopyMatrix(matrix), i - 1, j, summ);
            }

            // step top
            if (j - 1 >= 0 && matrix[i][j - 1].Gold != 0 && !matrix[i][j - 1].WasLocated)
            {
                Run(CopyMatrix(matrix), i, j - 1, summ);
            }

            // step bottom
            if (j + 1 < matrix[0].Length && matrix[i][j + 1].Gold != 0 && !matrix[i][j + 1].WasLocated)
            {
                Run(CopyMatrix(matrix), i, j + 1, summ);
            }
        }

        public static int GetMaximumGold(int[][] grid)
        {
            var matrix = FillMatrix(grid);

            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    ClearRoute(ref matrix);
                    if (matrix[i][j].Gold != 0)
                    {
                        Run(matrix, i, j, 0);
                    }
                }
            }

            return TotalSumm;
        }
    }
}
