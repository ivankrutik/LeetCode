namespace _1482._Minimum_Number_of_Days_to_Make_m_Bouquets
{
    internal static class Helper
    {
        private static bool checkData(int[] bloomDay, int m, int k, int target)
        {
            var counterFlowers = 0;
            var counterBouquets = 0;
            for (int i = 0; i < bloomDay.Length; i++)
            {
                if (bloomDay[i] <= target)
                    counterFlowers++;
                else
                    counterFlowers = 0;

                if (counterFlowers == k)
                {
                    counterFlowers = 0;
                    counterBouquets++;
                }
            }

            return counterBouquets >= m;
        }

        public static int MinDays(int[] bloomDay, int m/*кол букетов*/, int k/*кол цветков*/)
        {
            int result = -1;
            if (m * k > bloomDay.Length)
            {
                return result;
            }

            var l = 1;
            var r = bloomDay.Max();

            while (l <= r)
            {
                var target = (l + r) / 2;
                if (checkData(bloomDay, m, k, target))
                {
                    result = target;
                    r = target - 1;
                }
                else
                {
                    l = target + 1;
                }
            }
            return result;
        }
    }
}
