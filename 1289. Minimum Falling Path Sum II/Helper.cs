namespace _1289._Minimum_Falling_Path_Sum_II
{
    internal static class Helper
    {
        public static int MinFallingPathSum(int[][] grid)
        {
            int f = 0;
            int g = 0;
            int fp = -1;

            foreach (var row in grid)
            {
                var ff = int.MaxValue;
                var gg = int.MaxValue;
                var ffp = -1;

                for (var i = 0; i < row.Length; i++)
                {
                    int currSum = (fp != i ? f : g) + row[i];

                    if (currSum < ff)
                    {
                        gg = ff;
                        ff = currSum;
                        ffp = i;
                    }
                    else if (currSum < gg)
                    {
                        gg = currSum;
                    }

                }
                f = ff;
                g = gg;
                fp = ffp;
            }

            return f;
        }
    }
}
