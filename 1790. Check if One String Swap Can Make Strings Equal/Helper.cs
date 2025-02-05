namespace _1790._Check_if_One_String_Swap_Can_Make_Strings_Equal
{
    public static class Helper
    {
        public static bool AreAlmostEqual(string s1, string s2)
        {
            int count = 0;
            Tuple<char, char> pair1 = null;
            Tuple<char, char> pair2 = null;


            for (var i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    count++;

                    if (count == 1)
                        pair1 = new Tuple<char, char>(s1[i], s2[i]);
                    else if (count == 2)
                        pair2 = new Tuple<char, char>(s2[i], s1[i]);
                    else if (count > 2)
                        return false;
                }
            }

            return count == 0 || (count == 2 && pair1.Item1 == pair2.Item1 && pair1.Item2 == pair2.Item2);
        }
    }
}
