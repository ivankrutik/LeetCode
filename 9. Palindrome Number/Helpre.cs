namespace _09._Palindrome_Number
{

    public static class Helper
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            var str = x.ToString();
            var res = string.Empty;

            int n = str.Length;
            for (int i = n; i != 0; i--)
            {
                res += str[i - 1];
            }

            return str == res;
        }
    }
}
