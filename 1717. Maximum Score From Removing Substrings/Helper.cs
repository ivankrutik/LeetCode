namespace _1717._Maximum_Score_From_Removing_Substrings
{
    internal static class Helper
    {
        private static int res = 0;

        private static string getScore(string s, int score, string mask)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            Stack<char> chars = new Stack<char>();
            chars.Push(s[0]);

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == mask[1] && chars.Any() && mask[0] == chars.Peek())
                {
                    res = res + score;
                    chars.Pop();
                    continue;
                }
                chars.Push(s[i]);
            }
            var arr = chars.ToArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static int MaximumGain(string s, int x, int y)
        {
            //x - "ab"
            //y - "ba"
            if (x > y)
            {
                var str = getScore(s, x, "ab");
                getScore(str, y, "ba");
            }
            else
            {
                var str = getScore(s, y, "ba");
                getScore(str, x, "ab");
            }
            return res;
        }
    }
}
