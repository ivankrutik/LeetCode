using System.Text;

namespace _415._Add_Strings
{
    internal static class Helper
    {
        public static string AddStrings(string num1, string num2)
        {
            var maxLength = Math.Max(num1.Length, num2.Length);

            int[] arr1 = new int[maxLength];
            int[] arr2 = new int[maxLength];

            for (int i = 0; i < maxLength; i++)
            {
                if (num1.Length > i)
                {
                    arr1[i] = int.Parse(num1[num1.Length - i - 1].ToString());
                }
                else
                {
                    arr1[i] = 0;
                }

                if (num2.Length > i)
                {
                    arr2[i] = int.Parse(num2[num2.Length - i - 1].ToString());
                }
                else
                {
                    arr2[i] = 0;
                }
            }

            Boolean isOverflow = false;
            var res = new StringBuilder();

            for (int i = 0; i < maxLength; i++)
            {
                var sum = arr1[i] + arr2[i] + (isOverflow ? 1 : 0);
                if (sum >= 10)
                {
                    isOverflow = true;
                    sum = sum - 10;
                }
                else
                {
                    isOverflow = false;
                }
                res.Append(sum.ToString());
            }
            if (isOverflow)
            {
                res.Append("1");
            }

            return new string(res.ToString().Reverse().ToArray());
        }
    }
}
