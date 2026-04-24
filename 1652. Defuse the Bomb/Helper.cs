namespace _1652._Defuse_the_Bomb
{
    internal static class Helper
    {
        public static int[] Decrypt(int[] code, int k)
        {
            var res = new int[code.Length];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = 0;
            }
            if (k == 0)
                return res;

            for (int i = 0; i < code.Length; i++)
            {
                var sum = 0;
                int j = 0;
                while (Math.Abs(j) < Math.Abs(k))
                {
                    if (k > 0)
                        j++;
                    else
                        j--;

                    var index = (code.Length + ((i + j) % code.Length)) % code.Length;
                    sum += code[index];                    
                }
                res[i] = sum;
            }
            return res;
        }
    }
}
