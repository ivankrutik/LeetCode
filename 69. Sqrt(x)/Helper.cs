namespace _69._Sqrt_x_
{
    internal static class Helper
    {
        internal static int MySqrt(int x)
        {
            long left = 0;
            long right = x;
            long midle = 0;

            while (left <= right)
            {
                midle = (left + right) / 2;
                if (midle * midle < x)
                {
                    left = midle + 1;
                }
                else if (midle * midle > x)
                {
                    right = midle - 1;
                }
                else
                {
                    return (int)midle;
                }
            }
            return (int)right;
        }
    }
}
