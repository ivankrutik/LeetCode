namespace _2833._Furthest_Point_From_Origin
{
    public static class Helper
    {
        public static int FurthestDistanceFromOrigin(string moves)
        {
            int result = 0;
            int counter = 0;

            foreach (var move in moves) 
            {
                if (move == 'L')
                    result --;
                if (move == 'R')
                    result ++;
                if (move == '_')
                    counter ++;
            }
            result = Math.Abs(result) + counter;

            return result;
        }
    }
}
