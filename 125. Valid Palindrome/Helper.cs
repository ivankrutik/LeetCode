using System.Text.RegularExpressions;

namespace _125._Valid_Palindrome
{
    internal static class Helper
    {
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 1)
            {
                return true;
            }
            s = Regex.Replace(s, "[-.?!)(\\s,:;'@#_{}\\[\\]\"`]", "").ToLower();

            if (s.Length == 0)
            {
                return true;
            }

            int startIndex = 0;
            int endIndex = s.Length - 1;
            while (true)
            {
                if (s[startIndex] != s[endIndex])
                {
                    return false;
                }
                if (startIndex >= endIndex)
                {
                    return true;
                }
                startIndex++;
                endIndex--;
            }
        }
    }
}
