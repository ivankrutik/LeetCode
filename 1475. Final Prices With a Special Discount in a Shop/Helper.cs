namespace _1475._Final_Prices_With_a_Special_Discount_in_a_Shop
{
    internal static class Helper
    {
        public static int[] FinalPrices(int[] prices)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i+1; j < prices.Length; j++)
                {
                    if (prices[i] >= prices[j])
                    { 
                        prices[i] = prices[i] - prices[j];
                        break;
                    }
                }
            }
            return prices;
        }
    }
}
