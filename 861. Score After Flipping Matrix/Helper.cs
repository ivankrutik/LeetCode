using System.Collections;

namespace _861._Score_After_Flipping_Matrix
{
    internal static class Helper
    {
        private static int[] reverseRow(int[] row)
        {
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i] == 0)
                    row[i] = 1;
                else if (row[i] == 1)
                    row[i] = 0;
            }
            return row;
        }
        private static int[][] reverseColumn(int[][] grid, int column)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                if (grid[i][column] == 0)
                    grid[i][column] = 1;
                else if (grid[i][column] == 1)
                    grid[i][column] = 0;
            }
            return grid;
        }

        public static int MatrixScore(int[][] grid)
        {
            int maxCount = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                if (grid[i][0] == 0)
                {
                    grid[i] = reverseRow(grid[i]);
                }
            }

            for (int j = 1; j < grid[0].Length; j++)
            {
                int sumZero = 0;
                for (int i = 0; i < grid.Length; i++)
                {
                    if (grid[i][j] == 0)
                    {
                        sumZero++;
                    }
                }
                if (sumZero > grid.Length/2)
                    grid = reverseColumn(grid, j);
            }

            for (int i = 0; i < grid.Length; i++)
            {
                BitArray ba = new BitArray(grid[i].Length);
                int index = 0;
                for (int j = grid[i].Length - 1; j >= 0; j--)
                {
                    ba[index] = grid[i][j] == 1 ? true : false;
                    index++;
                }

                int[] array = new int[1];
                ba.CopyTo(array, 0);
                maxCount = maxCount + array[0];
            }

            return maxCount;
        }
    }
}