using System.Text;

namespace _791._Custom_Sort_String
{
    internal static class Helper
    {
        public static string CustomSortString(string order, string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < order.Length; i++)
            {
                dict.Add(order[i], i+1);
            }

            PriorityQueue<char, int> priorityQueue = new PriorityQueue<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    priorityQueue.Enqueue(s[i], dict[s[i]]);
                }
                else
                {
                    priorityQueue.Enqueue(s[i], 0);
                }
            }

            var sb = new StringBuilder();
            while (priorityQueue.Count != 0)
            {
                sb.Append(priorityQueue.Dequeue());
            }
            return sb.ToString();
        }
    }
}
