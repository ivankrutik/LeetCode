namespace _648._Replace_Words
{
    internal class Trie
    {
        // Trie содержит 26 потомков для каждой позиции маленькой буквы.
        private Trie[] children = new Trie[26];
        // 'ref' используется для хранения индекса из слова внутри словаря
        private int wordIndex = -1;

        // Метод вставляет слово и его индекс в Trie
        public void Insert(String word, int index)
        {
            Trie node = this;
            foreach (char c in word)
            {
                int charIndex = c - 'a'; // Считаем индекс символа
                if (node.children[charIndex] == null)
                {
                    // Если для этого символа нет дочернего узла Trie, то создвать его
                    node.children[charIndex] = new Trie();
                }
                node = node.children[charIndex];
            }
            node.wordIndex = index; // Сохранить индекс из слова в последнем узле
        }

        // Метод для поиска индекса кратчайшего корня в Trie, который является префиксом слова.
        public int Search(String word)
        {
            Trie node = this;
            foreach (char c in word)
            {
                int charIndex = c - 'a'; // Считаем индекс символа
                                         // Если для этого символа нет дочернего узла Trie, вернуть -1.
                if (node.children[charIndex] == null)
                {
                    return -1;
                }
                node = node.children[charIndex];
                // В каждом узле проверять, является ли он концом слова в словаре.
                if (node.wordIndex != -1)
                {
                    return node.wordIndex; // Вернуть сохраненный индекс, если мы нашли слово.
                }
            }
            return -1; // Если слово не найдено необходимо вернуть полное слово.
        }
    }
}
