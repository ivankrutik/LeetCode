namespace _2017._Grid_Game
{
    public static class Helper
    {

        public static long TotalR1 { get; set; }
        public static int[][]? MatrixR1 { get; set; }


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


        private static void FindPath(int X, int Y, int[][] matrix, long total)
        {
            total = total + matrix[X][Y];
            matrix[X][Y] = 0;

            if (total > TotalR1)
            {
                TotalR1 = total;
                MatrixR1 = CopyMatrix(matrix);
            }

            if (X + 1 < matrix.Length)
                FindPath(X + 1, Y, CopyMatrix(matrix), total);

            if (Y + 1 < matrix[X].Length)
                FindPath(X, Y + 1, CopyMatrix(matrix), total);
        }


        public static long GridGame(int[][] grid)
        {
            // 1st
            TotalR1 = 0;
            FindPath(0, 0, grid, 0);

            // 2st
            TotalR1 = 0;
            FindPath(0, 0, MatrixR1, 0);

            return TotalR1;
        }
    }
}
