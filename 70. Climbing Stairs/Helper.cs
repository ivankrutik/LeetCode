namespace _70._Climbing_Stairs
{
    internal static class Helper
    {
        internal static int ClimbStairs(int n)
        {
            int[] fibonachies = new int[n + 3];
            fibonachies[0] = 0;
            fibonachies[1] = 1;
            fibonachies[2] = 2;

            //fill array
            for (var i = 3; i <= n ; i++)
            {
                fibonachies[i] = fibonachies[i - 1] + fibonachies[i - 2];
            }

            return fibonachies[n];
        }
    }
}
