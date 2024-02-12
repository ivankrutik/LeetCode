namespace _279._Perfect_Squares
{
    internal static class Helper
    {
        private static bool perfectSquare(int n)
        {
            var temp = Math.Round(Math.Sqrt(n));
            if (n - temp * temp == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int getSquares(int n, int countQuadro)
        {
            if (perfectSquare(n))
            {
                return 1;
            }
            if (countQuadro == 1)
            {
                return 5;
            }

            int ans = 5;
            for (int first = 1; first*first <= n; first++)
            {
                ans = Math.Min(ans, 1 + getSquares(n - first * first, countQuadro - 1));
            }
            return ans;
        }

        public static int NumSquares(int n)
        {
            return getSquares(n, 4);
        }
    }
}
