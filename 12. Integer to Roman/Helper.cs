using System.Text;

namespace _12._Integer_to_Roman
{
    internal static class Helper
    {
        private static readonly int[] arabs = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static readonly string[] romes = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public static string IntToRoman(int num)
        {
            StringBuilder res = new StringBuilder();

            for (int i = 0; i < arabs.Length && num > 0; i++)
            {
                while (num >= arabs[i])
                {
                    res.Append(romes[i]);
                    num -= arabs[i];
                }
            }

            return res.ToString();
        }
    }
}
