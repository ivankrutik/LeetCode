namespace _402._Remove_K_Digits
{
    internal static class Helper
    {
        public static string RemoveKdigits(string num, int k)
        {
            if (num.Length == k)
            {
                return "0";
            }

            Stack<int> numbers = new Stack<int>();
            Stack<int> numbers2 = new Stack<int>();
            foreach (char c in num)
            {
                while (numbers.Any() && numbers.Peek() > int.Parse(c.ToString()) && k > 0)
                {
                    numbers.Pop();
                    k--;
                }
                numbers.Push(int.Parse(c.ToString()));
            }

            while (numbers.Any())
            {
                if (k > 0 && numbers.Peek() != 0)
                {
                    k--;
                    numbers.Pop();
                    continue;
                }
                numbers2.Push(numbers.Pop());
            }

            string res = string.Empty;
            while (numbers2.Any())
            {
                res += numbers2.Pop();
            }

            res = res.ToString().TrimStart('0');

            return res == "" ? "0": res;
        }
    }
}
