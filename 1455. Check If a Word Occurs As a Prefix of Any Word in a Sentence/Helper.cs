namespace _1455._Check_If_a_Word_Occurs_As_a_Prefix_of_Any_Word_in_a_Sentence
{
    internal static class Helper
    {
        public static int IsPrefixOfWord(string sentence, string searchWord)
        {
            var arr = sentence.Split(' ');
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToString().StartsWith(searchWord))
                    return i+1;
            }
            return -1;
        }
    }
}
