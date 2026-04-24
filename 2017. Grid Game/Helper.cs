namespace _2017._Grid_Game
{
    public static class Helper
    {
        public static long TopSum { get; set; }
        public static long BottomSum { get; set; }

        private static long GetMax(int[][] matrix, long index)
        {
            TopSum = TopSum - matrix[0][index];
            BottomSum = BottomSum + matrix[1][index - 1];

            return Math.Max(TopSum, BottomSum);
        }

        public static long GridGame(int[][] grid)
        {
            TopSum = 0;
            for (int i = 1; i < grid[0].Length; i++)
            {
                TopSum += grid[0][i];
            }
            BottomSum = 0;

            var total = TopSum;

            for (int i = 1; i < grid[0].Length; i++)
            {
                total = Math.Min(total, GetMax(grid, i));
            }

            return total;
        }
    }
}
