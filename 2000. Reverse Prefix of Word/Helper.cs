using System.Text;

namespace _2000._Reverse_Prefix_of_Word
{
    internal static class Helper
    {
        public static string ReversePrefix(string word, char ch)
        {
            Stack<char> stack = new Stack<char>();
            int? posExist = null;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ch)
                {
                    stack.Push(word[i]);
                }
                else
                {
                    stack.Push(word[i]);
                    posExist = i;
                    break;
                }
            }
            if (posExist == null)
            {
                return word;
            }

            while (stack.Any())
            {
                sb.Append(stack.Pop());
            }
            for (int i = (int)posExist + 1; i < word.Length; i++)
            {
                sb.Append(word[i]);
            }

            return sb.ToString();
        }
    }
}
