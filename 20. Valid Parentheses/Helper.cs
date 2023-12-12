namespace _20._Valid_Parentheses
{
    internal static class Helper
    {
        public static bool IsValid(string s)
        {
            if (s.Length % 2 == 1)
            {
                return false;
            }

            Stack<char> st = new Stack<char>();
            foreach (char c in s)
            {
                try
                {
                    var prev = st.Peek();

                    if (prev == '[' && c == ']')
                    {
                        st.Pop();
                    }
                    else if (prev == '(' && c == ')')
                    {
                        st.Pop();
                    }
                    else if (prev == '{' && c == '}')
                    {
                        st.Pop();
                    }
                    else
                    {
                        st.Push(c);
                    }
                }
                catch
                {
                    st.Push(c);
                    continue;
                }
            }

            return st.Count == 0;
        }
    }
}
