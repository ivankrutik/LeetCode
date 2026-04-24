namespace _2185._Counting_Words_With_a_Given_Prefix
{
    internal static class Helper
    {
        public static int PrefixCount(string[] words, string pref)
        {
            int count = 0;
            foreach (string word in words)
            {
                var isMath = true;
                if (word.Length<pref.Length)
                    continue;
                for (int i = 0; i < word.Length && i < pref.Length; i++)
                {
                    if (word[i] != pref[i])
                    {
                        isMath = false;
                       break;
                    }
                }
                if (isMath)
                    count++;
            }

            return count;
        }
    }
}
