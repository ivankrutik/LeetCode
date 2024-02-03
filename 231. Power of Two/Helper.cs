namespace _231._Power_of_Two
{
    internal class Helper
    {
        public static bool IsPowerOfTwo(int n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
