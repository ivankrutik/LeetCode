namespace _118._Pascal_s_Triangle
{
    internal static class Helper
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            var res = new List<IList<int>>();
            res.Add(new List<int>(1) { 1 });
            if (numRows == 1)
                return res;
            for (int i = 1; i < numRows; i++)
            {
                res.Add(new List<int>(i + 1));
                for (int j = 0; j <= i; j++)
                {
                    var summ = (j == 0 ? 0 : res[i - 1][j - 1]) + (j == i ? 0 : res[i - 1][j]);
                    res[i].Add(summ);
                }
            }
            return res;
        }
    }
}
