namespace _2073._Time_Needed_to_Buy_Tickets
{
    internal static class Helper
    {
        public static int TimeRequiredToBuy(int[] tickets, int k)
        {
            int res = 0;

            for (int i = 0; i < tickets.Length; i++)
            {
                if (i <= k)
                {
                    res = res + Math.Min(tickets[i], tickets[k]);
                }
                if (i > k)
                {
                    if (tickets[k] > tickets[i])
                    {
                        res = res + tickets[i];
                    }
                    else
                    {
                        res = res + Math.Min(tickets[i] - 1, tickets[k] - 1);
                    }
                }
            }
            return res;
        }
    }
}
