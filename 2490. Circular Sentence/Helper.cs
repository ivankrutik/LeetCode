namespace _2490._Circular_Sentence
{
    internal static class Helper
    {
        public static bool IsCircularSentence(string sentence)
        {
            var arr = sentence.Split(' ');
            //1й и последний в строке
            if (arr[0][0] != arr[arr.Length - 1][arr[arr.Length - 1].Length - 1])
                return false;

            for (var i = 0; i < arr.Length - 1; i++)
            {
                // между словами
                var f = arr[i][arr[i].Length - 1];
                var l = arr[i + 1][0];
                if (f != l)
                    return false;
            }
            return true;
        }
    }
}
