namespace _1137._N_th_Tribonacci_Number
{
    internal static class Helper
    {
        public static int Tribonacci(int n)
        {
            long[] dict = new long[n+3];
            dict[0] = 0;
            dict[1] = 1;
            dict[2] = 1;

            if (n <= 2)
            {
                return (int)dict[n];
            }

            for (int i = 3; i <= n; i++) 
            {
                dict[i] = dict[i-1] + dict[i-2] + dict[i-3];
            }
            return (int)dict[n];
        }
    }
}
