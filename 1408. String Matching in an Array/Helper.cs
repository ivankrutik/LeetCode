namespace _1408._String_Matching_in_an_Array
{
    internal static class Helper
    {
        public static IList<string> StringMatching(string[] words)
        {
            var res = new List<string>();
            words = words.OrderByDescending(x => x.Length).ToArray();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i-1; j >= 0; j--)
                {
                    if (words[j].Contains(words[i]))
                    {
                        res.Add(words[i]);
                        break;
                    }
                }
            }
            return res;
        }
    }
}
