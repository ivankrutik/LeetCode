namespace _121._Best_Time_to_Buy_and_Sell_Stock
{
    internal static class Helper
    {
        public static int MaxProfit(int[] prices)
        {
            var res = 0;
            int prevMin = int.MaxValue;
            foreach (var pr in prices) 
            {
                res = Math.Max(res, pr - prevMin);
                prevMin = Math.Min(prevMin, pr);
            }
                       
            return res;
        }
    }
}
