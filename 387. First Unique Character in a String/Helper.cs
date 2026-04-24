namespace _387._First_Unique_Character_in_a_String
{
    public static class Helper
    {
        public static int FirstUniqChar(string s)
        {
            HashSet<char> set = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (set.Contains(s[i])) continue;
                
                bool IsMath = false;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        IsMath = true;
                        set.Add(s[i]);
                        break;
                    }
                }

                if (!IsMath)
                    return i;
            }

            return -1;
        }
    }
}
