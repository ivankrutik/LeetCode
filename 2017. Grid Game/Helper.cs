namespace _2017._Grid_Game
{
    public static class Helper
    {
        public static long TotalR1 { get; set; }
        public static long MaxSum { get; set; }

        private static int[][] CopyMatrix(int[][] grid)
        {
            int[][] matrix = new int[grid.Length][];

            for (int i = 0; i < matrix.Length; ++i)
            {
                matrix[i] = new int[grid[i].Length];

                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    matrix[i][j] = grid[i][j];
                }
            }
            return matrix;
        }

        private static void GetMax(int X, int Y, int[][] matrix, long total)
        {
            total = total + matrix[X][Y];
            matrix[X][Y] = 0;

            if (total > MaxSum)
            {
                MaxSum = total;
            }

            if (X + 1 < matrix.Length)
                GetMax(X + 1, Y, CopyMatrix(matrix), total);

            if (Y + 1 < matrix[X].Length)
                GetMax(X, Y + 1, CopyMatrix(matrix), total);
        }


        private static void FindPath(int X, int Y, int[][] matrix)
        {
            bool isEnd = true;
            matrix[X][Y] = 0;

            if (X + 1 < matrix.Length)
            {
                isEnd = false;
                FindPath(X + 1, Y, CopyMatrix(matrix));
            }

            if (Y + 1 < matrix[X].Length)
            {
                isEnd = false;
                FindPath(X, Y + 1, CopyMatrix(matrix));
            }

            if (isEnd)
            {
                MaxSum = 0;
                GetMax(0, 0, matrix, 0);
                TotalR1 = Math.Min(TotalR1, MaxSum);
            }
        }


        public static long GridGame(int[][] grid)
        {
            // 1st
            GetMax(0, 0, grid, 0);
            TotalR1 = MaxSum;
            FindPath(0, 0, grid);

            return TotalR1;
        }
    }
}
