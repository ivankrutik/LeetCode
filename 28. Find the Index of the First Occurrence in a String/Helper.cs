using static System.Net.Mime.MediaTypeNames;

namespace _28._Find_the_Index_of_the_First_Occurrence_in_a_String
{
    internal static class Helper
    {
        static int[] GetPrefix(string s)
        {
            int[] result = new int[s.Length];
            result[0] = 0;
            int index = 0;

            for (int i = 1; i < s.Length; i++)
            {
                int k = result[i - 1];
                while (s[k] != s[i] && k > 0)
                {
                    k = result[k - 1];
                }
                if (s[k] == s[i])
                {
                    result[i] = k + 1;
                }
                else
                {
                    result[i] = 0;
                }
            }
            return result;
        }


        public static int StrStr(string haystack, string needle)
        {
            if (haystack == null || needle == null)
            {
                return -1;
            }

            int[] pf = GetPrefix(needle);

            int index = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                while (index > 0 && needle[index] != haystack[i])
                { 
                    index = pf[index - 1]; 
                }

                if (needle[index] == haystack[i]) 
                    index++;

                if (index == needle.Length)
                {
                    return i - index + 1;
                }
            }

            return -1;
        }
    }
}