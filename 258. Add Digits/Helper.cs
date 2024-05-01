namespace _258._Add_Digits
{
    internal static class Helper
    {
        public static int AddDigits(int num)
        {
            if (num == 0) 
                return 0;

            var r = num % 9;

            return r == 0 ? 9 : r;
        }
    }
}
