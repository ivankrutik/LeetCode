namespace _2696._Minimum_String_Length_After_Removing_Substrings
{
    internal static class Helper
    {
        private static string templateA = "AB";
        private static string templateB = "CD";

        private static string RemoveChars(string s)
        {
            bool isExists = false;
            var ch = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length)
                {
                    if ((i + 1 >= s.Length || (s[i].ToString() + s[i + 1].ToString()) != templateA) && (s[i].ToString() + s[i + 1].ToString()) != templateB)
                    {
                        ch[i] = s[i];
                    }
                    else
                    {
                        i++;
                        isExists = true;
                    }
                }
                else
                    ch[i] = s[i];
            }
            string res = string.Empty;
            foreach (var c in ch)
            {
                if (c != '\0')
                {
                    res += c;
                }                
            }
            if (isExists)
                res = RemoveChars(res);

            return res;
        }


        public static int MinLength(string s)
        {
            var r = RemoveChars(s);
            return r.Length;
        }
    }
}
