using System.Numerics;

namespace _66._Plus_One
{
    public static class Helper
    {
        public static int[] PlusOne(int[] digits)
        {

            string numText = string.Empty;
            foreach (int digit in digits)
            {
                numText = numText + digit;
            }
            BigInteger num = BigInteger.Parse(numText);
            num++;

            numText = num.ToString();

            int[] res = new int[numText.ToCharArray().Length];
            var numArr = numText.ToCharArray();

            for (int i = 0; i < numArr.Length; i++)
            {
                res[i] = int.Parse(numArr[i].ToString());
            }

            return res;

        }
    }
}
