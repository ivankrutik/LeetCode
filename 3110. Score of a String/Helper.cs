namespace _3110._Score_of_a_String
{
    internal static class Helper
    {
        public static int ScoreOfString(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length-1; i++)
            {
                sum = sum + Math.Abs(s[i] - s[i + 1]);
            }
            return sum;
        }
    }
}
