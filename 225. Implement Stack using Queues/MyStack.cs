using System.Security.AccessControl;

namespace _225._Implement_Stack_using_Queues
{
    public class MyStack
    {
        private Queue<int> _queue { get; set; }
        private Queue<int> _queueTemp { get; set; }

        private void ReplaceQueue()
        {
            if (!_queue.Any())
            {
                while (_queueTemp.Any())
                {
                    _queue.Enqueue(_queueTemp.Dequeue());
                }
                while (_queue.Count != 1)
                {
                    _queueTemp.Enqueue(_queue.Dequeue());
                }
            }
            else
            {
                while (_queue.Count != 1)
                {
                    _queueTemp.Enqueue(_queue.Dequeue());
                }
            }
        }

        public MyStack()
        {
            _queue = new Queue<int>();
            _queueTemp = new Queue<int>();
        }

        public void Push(int x)
        {
            _queue.Enqueue(x);
        }

        public int Pop()
        {
            ReplaceQueue();
            return _queue.Dequeue();
        }

        public int Top()
        {
            ReplaceQueue();
            return _queue.Peek();
        }

        public bool Empty()
        {
            if (_queue.Any() || _queueTemp.Any())
            {
                return false;
            }
            return true;
        }
    }
}
