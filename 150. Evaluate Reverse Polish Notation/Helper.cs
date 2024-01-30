namespace _150._Evaluate_Reverse_Polish_Notation
{
    internal static class Helper
    {
        private static Stack<int> _stack = new Stack<int>();
        private static List<string> _operations = new List<string>() { "+", "-", "*", "/" };

        public static int EvalRPN(string[] tokens)
        {
            int t1;
            int t2;
            for (int i = 0; i < tokens.Length; i++)
            {
                //понять операция или операнд
                if (!_operations.Contains(tokens[i]))
                {
                    _stack.Push(int.Parse(tokens[i]));
                }
                else
                {
                    t2 = _stack.Pop();
                    t1 = _stack.Pop();
                    switch (tokens[i])
                    {
                        case "+":
                            {
                                _stack.Push(t1 + t2);
                                break;
                            }
                        case "-":
                            {
                                _stack.Push(t1 - t2);
                                break;
                            }
                        case "/":
                            {
                                _stack.Push(t1 / t2);
                                break;
                            }
                        case "*":
                            {
                                _stack.Push(t1 * t2);
                                break;
                            }
                    }
                }
            }
            return _stack.Pop();
        }
    }
}
