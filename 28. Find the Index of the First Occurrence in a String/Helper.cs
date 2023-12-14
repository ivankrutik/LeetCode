namespace _28._Find_the_Index_of_the_First_Occurrence_in_a_String
{
    internal static class Helper
    {
        public static int StrStr(string haystack, string needle)
        {
            if (haystack == null || needle == null || haystack.Length < needle.Length)
            {
                return -1;
            }

            int mathCount = 0;

            for (var j = 0; j < haystack.Length; j++)
            {
                //проверка по первому символу
                if (needle[0] == haystack[j])
                {
                    mathCount = 0;

                    for (var i = 0; i < needle.Length; i++)
                    {
                        if ((j + i) < haystack.Length && haystack[j + i] == needle[i])
                        {
                            mathCount++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (mathCount == needle.Length)
                    {
                        return j;
                    }
                }
            }

            return -1;
        }
    }
}