namespace _2108._Find_First_Palindromic_String_in_the_Array
{
    internal static class Helper
    {
        private static bool IsPalindrome(string word)
        {
            var l = 0;
            var r = word.Length - 1;

            while (l <= r)
            {
                if (word[l] != word[r])
                {
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }

        public static string FirstPalindrome(string[] words)
        {
            foreach (string word in words)
            {
                if (IsPalindrome(word))
                    return word;
            }
            return string.Empty;
        }
    }
}
