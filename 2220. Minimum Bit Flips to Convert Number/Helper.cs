namespace _2220._Minimum_Bit_Flips_to_Convert_Number
{
    internal static class Helper
    {
        public static int MinBitFlips(int start, int goal)
        {
            var res = ((uint)(start ^ goal));
            return Convert.ToString(res, toBase: 2).Count(c => c == '1');
        }
    }
}
