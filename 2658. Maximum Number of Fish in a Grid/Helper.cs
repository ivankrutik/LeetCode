using System.Reflection;

namespace _2658._Maximum_Number_of_Fish_in_a_Grid
{
    public static class Helper
    {
        public class Coordinate
        {
            public int X;
            public int Y;
        }

        private static int _maxNumber;

        private static int _pointer;

        private static void GetMaxFish(int i, int j, int[][] grid, List<Coordinate> coordinates)
        {
            if (grid[i][j] == 0 || coordinates.Any(z => z.X == i && z.Y == j))
                return;

            coordinates.Add(new Coordinate { X = i, Y = j });

            _pointer = _pointer + grid[i][j];

            if (i + 1 < grid.Length)
                GetMaxFish(i + 1, j, grid, coordinates);

            if (i - 1 >= 0)
                GetMaxFish(i - 1, j, grid, coordinates);

            if (j + 1 < grid[i].Length)
                GetMaxFish(i, j + 1, grid, coordinates);

            if (j - 1 >= 0)
                GetMaxFish(i, j - 1, grid, coordinates);

            _maxNumber = Math.Max(_maxNumber, _pointer);
        }

        public static int FindMaxFish(int[][] grid)
        {
            _maxNumber = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    _pointer = 0;
                    GetMaxFish(i, j, grid, new List<Coordinate>());
                }
            }

            return _maxNumber;
        }
    }
}
