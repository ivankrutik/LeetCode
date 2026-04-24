namespace _2558._Take_Gifts_From_the_Richest_Pile
{
    internal static class Helper
    {
        public static long PickGifts(int[] gifts, int k)
        {

            long sum = 0;
            int position = 0;
            gifts = gifts.OrderByDescending(x => x).ToArray();

            for (int i = 0; i < k; i++)
            {
                var maxPosition = position;
                var currValue = gifts[position];
                for (int j = 1; j <= position; j++)
                {
                    if (currValue < gifts[position - j])
                    { 
                        currValue = gifts[position - j];
                        maxPosition = position - j;
                    }
                }

                gifts[maxPosition] = (int)Math.Sqrt(double.Parse( gifts[maxPosition].ToString()));
                position += 1;

                if (position > gifts.Length/3)
                {
                    gifts = gifts.OrderByDescending(x => x).ToArray();
                    position = 0;
                }
            }
            foreach (int gift in gifts)
            {
                sum += gift;
            }

            return sum;
        }
    }
}
