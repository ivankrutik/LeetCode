namespace _344._Reverse_String
{
    internal static class Helper
    {
        public static char[] ReverseString(char[] s)
        {
            var left = 0;
            var right = s.Length-1;
            char temp;
            while (left < right) 
            {
                temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }
            return s;
        }
    }
}
