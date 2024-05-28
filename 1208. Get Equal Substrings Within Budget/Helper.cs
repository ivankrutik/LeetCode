namespace _1208._Get_Equal_Substrings_Within_Budget
{
    internal static class Helper
    {
        public static int EqualSubstring(string s, string t, int maxCost)
        {
            // Длина входной строки
            int length = s.Length;

            // Накопительная стоимость трансформации
            int cumulativeCost = 0;

            // Это будет отслеживать подстроку максимальной длины, которая соответствует условию
            int maxLength = 0;

            // Техника двух указателей
            // Start и end указатели для скользящего окна
            int start = 0;
            for (var end = 0; end < length; ++end)
            {
                // Считаем и добавляем стоимсоть изменения с s[end] на t[end]
                cumulativeCost += Math.Abs(s[end] - t[end]);

                //Если накопительная стоимость больше maxCost сократим окно до самого начала
                while (cumulativeCost > maxCost)
                {
                    //Удаляем стоимость начального символа, т.к. мы собираемся его исключить
                    cumulativeCost -= Math.Abs(s[start] - t[start]);
                    // Переведем указатель start вперед
                    ++start;
                }

                // Обновить найденную максимальную длину (end - start + 1 текущий размер окна)
                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }
    }
}
