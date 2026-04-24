namespace _648._Replace_Words
{
    internal static class Helper
    {
        public static string ReplaceWords(IList<string> dictionary, string sentence)
        {
            var trie = new Trie();
            // Вставить все словарные слова в Trie с соответствующими индексами.
            for (int i = 0; i < dictionary.Count(); i++)
            {
                trie.Insert(dictionary[i], i);
            }

            // Разделить sentence на слова
            var words = sentence.Split(" ");
            // Список для хранения предложения после замен.
            var modifiedSentence = new List<string>();
            foreach (string word in words)
            {
                // Для каждого слова найти в Trie индекс кратчайшего корня.
                int index = trie.Search(word);
                // Если корень найден, заменить слово корнем; в противном случае оставить слово как есть.
                modifiedSentence.Add(index == -1 ? word : dictionary[index]);
            }
            // Объединить слова в строку через пробел
            return String.Join(" ", modifiedSentence);
        }
    }
}
