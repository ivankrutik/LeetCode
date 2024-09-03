namespace _1894._Find_the_Student_that_Will_Replace_the_Chalk
{
    internal static class Helper
    {
        public static int ChalkReplacer(int[] chalk, int k)
        {
            int i = 0;
            while (k - chalk[i] >= 0)
            {
                k = k - chalk[i];

                if (i + 1 == chalk.Length)
                {
                    i = 0;
                    continue;
                }
                else
                {
                    i++;
                }
            }
            return i;
        }
    }
}
