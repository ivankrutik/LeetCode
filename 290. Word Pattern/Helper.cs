namespace _290._Word_Pattern
{
    internal static class Helper
    {
        public static bool WordPattern(string pattern, string s)
        {
            Dictionary<char, string> dict = new Dictionary<char, string>();
            var arr = s.Split(' ');
            if (arr.Length != pattern.Length)
            {
                return false;
            }

            for (int i = 0; i < pattern.Length; i++)
            {
                if (dict.ContainsKey(pattern[i]))
                {
                    if (dict[pattern[i]] != arr[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (dict.ContainsValue(arr[i]))
                    {
                        return false;
                    }
                    dict.Add(pattern[i], arr[i]);
                }
            }

            return true;
        }
    }
}
