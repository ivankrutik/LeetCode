namespace _1552._Magnetic_Force_Between_Two_Balls
{
    internal static class Helper
    {
        private static bool isCheck(int[] position, int m, int midle)
        {
            var countBoll = 1;
            var index = 0;
            for (int i = 1; i < position.Length; i++)
            {
                if (position[i] - position[index] >= midle)
                { 
                    countBoll++;
                    index = i;
                }
                if (countBoll >= m)
                {
                    break;
                }
            }

            return countBoll >= m;
        }


        public static int MaxDistance(int[] position, int m)
        {
            var minPower = 0;
            position = position.OrderBy(x => x).ToArray();
            var l = 1;
            var r = position.Last();

            while (l <= r)
            {
                var midle = (l + r) / 2;

                if (isCheck(position, m, midle))
                {
                    minPower = midle;
                    l = midle + 1;
                }
                else
                {
                    r = midle - 1;
                }
            }
            return minPower;
        }
    }
}
