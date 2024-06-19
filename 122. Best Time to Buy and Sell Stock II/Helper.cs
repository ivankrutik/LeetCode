namespace _122._Best_Time_to_Buy_and_Sell_Stock_II
{
    internal static class Helper
    {
        public static int MaxProfit(int[] prices)
        {
            int sum = 0;

            for (int i = prices.Length - 1; i >= 0; i--)
            {
                if (i - 1 >= 0 && prices[i] > prices[i - 1])
                {
                    sum += prices[i] - prices[i - 1];
                }
            }

            return sum;
        }
    }
}
