namespace _1945_Sum_of_Digits_of_String_After_Convert
{
    internal static class Helper
    {
        public static int GetLucky(string s, int k)
        {
            var inInt = new List<int>();
            int sum = 0;

            foreach (var c in s)
            {
                int position = ((int)c) - 96;

                foreach (var c0 in position.ToString())
                {
                    int cifr = int.Parse(c0.ToString());
                    inInt.Add(cifr);
                }
            }

            for (int i = 0; i < k; i++)
            {
                sum = inInt.Sum(x => x);

                inInt.Clear();
                foreach (var c0 in sum.ToString())
                {
                    int cifr = int.Parse(c0.ToString());
                    inInt.Add(cifr);
                }
            }

            return sum;
        }
    }
}
