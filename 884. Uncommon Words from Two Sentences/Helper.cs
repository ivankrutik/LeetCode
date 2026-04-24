namespace _884._Uncommon_Words_from_Two_Sentences
{
    internal static class Helper
    {
        public static string[] UncommonFromSentences(string s1, string s2)
        {
            Dictionary<string, string> dictAll = new Dictionary<string, string>();
            Dictionary<string, string> dictUk = new Dictionary<string, string>();

            foreach (string word in (s1 + " " + s2).Split(" "))
            {
                if (!dictAll.ContainsKey(word))
                {
                    dictUk.Add(word, word);
                    dictAll.Add(word, word);
                }
                else
                {
                    dictUk.Remove(word);
                }
            }

            return dictUk.Keys.ToArray();
        }
    }
}
