namespace _14._Longest_Common_Prefix
{

    public static class Helper
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            var sortedList = new SortedList<string, int>();

            for (var i = 0; i < strs.Count(); i++)
            {
                if (!sortedList.ContainsKey(strs[i]))
                {
                    sortedList.Add(strs[i], i);
                }

            }

            var index = 0;
            char currentChar;
            string res = string.Empty;

            //var word = sortedList.GetKeyAtIndex(0).ToString();
            var word = sortedList.FirstOrDefault().Key.ToString();
            foreach (var charInWord in word.ToCharArray())
            {
                currentChar = charInWord;

                foreach (var str in sortedList)
                {
                    if (str.Key[index] != currentChar)
                    {
                        return res;
                    }
                }
                res += charInWord;
                index++;
            }

            return res;
        }
    }
}
