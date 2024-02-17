namespace _1422._Maximum_Score_After_Splitting_a_String
{
    internal static class Helper
    {
        public static int MaxScore(string s)
        {
            var left = 0;
            var right = s.Where(x => x == '1').Count();
            var score = 0;
            for (var i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == '0')
                    left++;
                else
                    right--;

                score = Math.Max(score, left + right);
            }
            return score;
        }
    }
}
