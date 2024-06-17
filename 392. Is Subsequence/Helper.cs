namespace _392._Is_Subsequence
{
    internal static class Helper
    {
        public static bool IsSubsequence(string s, string t)
        {
            int countMath = 0;
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                while (index < t.Length)
                {
                    if (s[i] == t[index])
                    {
                        index++;
                        countMath++;
                        break;
                    }
                    index++;
                }
            }
            return countMath == s.Length;
        }
    }
}
