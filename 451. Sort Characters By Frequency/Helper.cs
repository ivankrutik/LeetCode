using System.Text;

namespace _451._Sort_Characters_By_Frequency
{
    internal static class Helper
    {
        public static string FrequencySort(string s)
        {
            var dict = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            var sb = new StringBuilder();
            foreach (var c in dict.OrderByDescending(x => x.Value))
            {
                for (var i = 0; i < c.Value; i++) 
                {
                    sb.Append(c.Key);
                }                
            }

            return sb.ToString();
        }
    }
}
