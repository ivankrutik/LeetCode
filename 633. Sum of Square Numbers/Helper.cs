
namespace _633._Sum_of_Square_Numbers
{
    internal static class Helper
    {
        public static bool JudgeSquareSum(int c)
        {
            long a = 0;
            long b = (int)Math.Ceiling(Math.Sqrt(c));

            while (a <= b)
            {
                long sum = a * a + b * b;
                if (sum == c)
                {
                    return true;
                }

                if (sum < c)
                {
                    a++;
                }
                else
                {
                    b--;
                }
            }

            return false;
        }
    }
}
