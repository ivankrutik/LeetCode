namespace _232._Implement_Queue_using_Stacks
{
    public class MyQueue
    {
        private Stack<int> _in;
        private Stack<int> _out;

        public MyQueue()
        {
            _in = new Stack<int>();
            _out = new Stack<int>();
        }

        public void Push(int x)
        {
            _in.Push(x);
        }

        public int Pop()
        {
            if (_out.Any())
            {
                return _out.Pop();
            }
            while (true)
            {
                if (_in.Count == 0)
                    break;

                _out.Push(_in.Pop());
            }
            return _out.Pop();
        }

        public int Peek()
        {
            if (_out.Any())
            {
                return _out.Peek();
            }
            while (true)
            {
                if (_in.Count == 0)
                    break;

                _out.Push(_in.Pop());
            }
            return _out.Peek();
        }

        public bool Empty()
        {
            if (_in.Any() || _out.Any())
                return false;
            else return true;
        }
    }
}
