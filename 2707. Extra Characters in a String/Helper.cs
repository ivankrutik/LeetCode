namespace _2707._Extra_Characters_in_a_String
{
    public static class Helper
    {
        private static int Total = int.MaxValue;

        private static void RemoveWord(string s, string[] dictionary)
        {
            Total = Math.Min(Total, s.Where(z => z != '_').Count());

            foreach (string word in dictionary)
            {
                if (s.Contains(word))
                {
                    var s2 = s.Replace(word, "_");
                    RemoveWord(s2, dictionary);
                }
            }
        }

        public static int MinExtraChar(string s, string[] dictionary)
        {
            RemoveWord(s, dictionary);
            return Total;
        }
    }
}
