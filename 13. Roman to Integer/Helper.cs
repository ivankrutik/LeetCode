namespace _13._Roman_to_Integer
{
    internal static class Helper
    {
        private static Dictionary<char, int> _dictLiter = new Dictionary<char, int>(7)
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public static int RomanToInt(string s)
        {
            int res = 0;

            for (var i = 0; i < s.Length; i++)
            {
                /*определим +/-*/
                if ((i + 1) < s.Length &&
                    ((s[i] == 'I' && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                    ||
                    (s[i] == 'X' && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                     ||
                    (s[i] == 'C' && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                    ))
                //-
                {
                    res = res - _dictLiter[s[i]];
                }
                //+
                else
                {
                    res = res + _dictLiter[s[i]];
                }
            }

            return res;
        }
    }
}