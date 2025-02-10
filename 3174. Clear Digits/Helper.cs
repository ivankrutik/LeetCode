namespace _3174._Clear_Digits
{
    public static class Helper
    {
        public static string ClearDigits(string s)
        {
            var chars = new Stack<char>();

            foreach (char c in s)
            {
                if ('0' <= c && c <= '9')
                {
                    if (chars.Any())
                        chars.Pop();
                }
                else
                    chars.Push(c);
            }

            return new string( chars.Reverse().ToArray());
        }
    }
}
