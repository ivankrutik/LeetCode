namespace _2485._Find_the_Pivot_Integer
{
    internal static class Helper
    {
        private static int getSumm(int n)
        {
            decimal num = n;
            decimal r = (num / 2) * (1 + num);
            return (int)r;
        }

        private static int? Pivot { get; set; }

        private static void getPivot(int n, int left, int right)
        {
            if (left > right)
            {
                return;
            }
            if (Pivot != null)
            {
                return;
            }

            int pivot = (left + right) / 2;
            int sum1 = getSumm(pivot);
            int sum2 = getSumm(n) - sum1 + pivot;

            if (sum1 == sum2)
            {
                Pivot = pivot;
                return;
            }
            else
            {
                if (sum1 > sum2)
                {
                    right = pivot - 1;
                }
                else
                {
                    left = pivot + 1;
                }
                getPivot(n, left, right);
            }
        }

        public static int PivotInteger(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            getPivot(n, 1, n);
            return Pivot == null ? -1 : (int)Pivot;
        }
    }
}
