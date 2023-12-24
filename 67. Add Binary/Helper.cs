namespace _67._Add_Binary
{
    public static class Helper
    {
        public static string AddBinary(string a, string b)
        {
            var aa = new string(a.Reverse().ToArray());
            var bb = new string(b.Reverse().ToArray());

            int aaLength = a.Length;
            int bbLength = b.Length;
            int length = Math.Max(a.Length, b.Length);
            string res = string.Empty;

            bool isDischarge = false;
            int counter = 0;

            for (int i = 0; i < length; i++)
            {
                if (aaLength > i && bbLength > i)
                {
                    counter = int.Parse(aa[i].ToString()) + int.Parse(bb[i].ToString()) + (isDischarge ? 1 : 0);
                }
                else if (aaLength > i)
                {
                    counter = int.Parse(aa[i].ToString()) + (isDischarge ? 1 : 0);
                }
                else if (bbLength > i)
                {
                    counter = int.Parse(bb[i].ToString()) + (isDischarge ? 1 : 0);
                }

                isDischarge = false;

                if (counter >= 2)
                {
                    isDischarge = true;
                    counter = counter % 2;
                }

                res = res + counter.ToString();
            }
            if (isDischarge)
            {
                res = res + "1";
            }

            return new string(res.Reverse().ToArray());
            //return Convert.ToString((Convert.ToInt64(a, 2) + Convert.ToInt64(b, 2)), 2);
        }
    }
}
