namespace _2707._Extra_Characters_in_a_String
{
    public static class Helper
    {
        public static int MinExtraChar(string s, string[] dictionary)
        {
            // Create a set from the dictionary for efficient lookup of words.
            // Создайте набор из словаря для эффективного поиска слов.
            HashSet<string> wordSet = new HashSet<string>();
            foreach (var word in dictionary)
            {
                wordSet.Add(word);
            }

            // Get the length of the string s
            // Получить длину строки s
            int n = s.Length;

            // Create an array to store the minimum number of extra characters needed.
            // Создайте массив для хранения минимально необходимого количества дополнительных символов.
            // f[i] will be the minimum count for substring s[0..i)
            // f[i] будет минимальным счетчиком для подстроки s[0..i)
            int[] minExtraChars = new int[n + 1];

            // Base case: no extra characters needed for an empty string
            // Базовый случай: для пустой строки не требуются дополнительные символы.
            minExtraChars[0] = 0;

            // Iterate over each character in the string
            // Перебирать каждый символ в строке
            for (int i = 1; i <= n; ++i)
            {
                // By default, assume one more extra char than the minExtraChars of the previous substring
                // По умолчанию предполагается, что на один дополнительный символ больше, чем minExtraChars предыдущей подстроки.
                minExtraChars[i] = minExtraChars[i - 1] + 1;

                // Check each possible substring ending at current character i
                for (int j = 0; j < i; ++j)
                {
                    // If the substring from index j to i is in the dictionary,
                    // update minExtraChars[i] if a smaller value is found
                    var w = s.Substring(j,  i - j);
                    if (wordSet.Contains(w))
                    {
                        minExtraChars[i] = Math.Min(minExtraChars[i], minExtraChars[j]);
                    }
                }
            }

            // Return the minimum extra characters for the entire string
            return minExtraChars[n];
        }
    }
}
