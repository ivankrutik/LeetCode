namespace _1957._Delete_Characters_to_Make_Fancy_String
{
    internal static class Helper
    {
        public static string MakeFancyString(string s)
        {
            Queue<char> queue = new Queue<char>();

            int count = 0;
            char lastChar = '\0';
            for (int i = 0; i < s.Length; i++) 
            {
                if (lastChar == s[i])
                {
                    count++;
                    if (count >2)
                    {
                        continue;
                    }
                }
                else
                {
                    count = 1;
                }
                lastChar = s[i];
                queue.Enqueue(s[i]);
            }

            return new string( queue.ToArray());
        }
    }
}
