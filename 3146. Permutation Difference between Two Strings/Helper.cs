namespace _3146._Permutation_Difference_between_Two_Strings
{
    internal static class Helper
    {
        public static int FindPermutationDifference(string s, string t)
        {
            Dictionary<char, int> d1 = new Dictionary<char, int>();
            Dictionary<char, int> d2 = new Dictionary<char, int>();
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                d1.Add(s[i], i);
            }
            for (int i = 0; i < t.Length; i++)
            {
                d2.Add(t[i], i);
            }
            foreach (var value in d1)
            {
                count = count + Math.Abs((value.Value - d2[value.Key]));
            }

            return count;
        }
    }
}
