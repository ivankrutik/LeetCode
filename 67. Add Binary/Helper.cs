using System.Text;

namespace _67._Add_Binary
{
    public static class Helper
    {
        public static string AddBinary(string a, string b)
        {
            a = new string(a.Reverse().ToArray());
            b = new string(b.Reverse().ToArray());

            int aaLength = a.Length;
            int bbLength = b.Length;
            int length = Math.Max(a.Length, b.Length);

            bool isDischarge = false;
            int counter = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                if (aaLength > i && bbLength > i)
                {
                    counter = int.Parse(a[i].ToString()) + int.Parse(b[i].ToString()) + (isDischarge ? 1 : 0);
                }
                else if (aaLength > i)
                {
                    counter = int.Parse(a[i].ToString()) + (isDischarge ? 1 : 0);
                }
                else if (bbLength > i)
                {
                    counter = int.Parse(b[i].ToString()) + (isDischarge ? 1 : 0);
                }

                isDischarge = false;

                if (counter >= 2)
                {
                    isDischarge = true;
                    counter = counter % 2;
                }

                sb.Append(counter.ToString());
            }
            if (isDischarge)
            {
                sb.Append("1");
            }
            return new string(sb.ToString().Reverse().ToArray());

            //return Convert.ToString((Convert.ToInt64(a, 2) + Convert.ToInt64(b, 2)), 2);
        }
    }
}
