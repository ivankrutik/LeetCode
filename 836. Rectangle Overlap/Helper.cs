namespace _836._Rectangle_Overlap
{
    internal static class Helper
    {
        private class Rectangle
        {
            public (int, int) LeftDownPointer { get; set; }
            public (int, int) RightTopPointer { get; set; }

            public (int, int) CoordinatesX { get; set; }
            public (int, int) CoordinatesY { get; set; }
        }

        private static bool IsMath((int, int) segment1, (int, int) segment2)
        {
            if ((segment1.Item1 < segment2.Item1 && segment2.Item1 < segment1.Item2)
                || (segment1.Item1 < segment2.Item2 && segment2.Item2 < segment1.Item2)
                || (segment2.Item1 < segment1.Item1 && segment1.Item1 < segment2.Item2)
                || (segment2.Item1 < segment1.Item2 && segment1.Item2 < segment2.Item2))
            {
                return true;
            }
            return false;
        }

        public static bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            var rectangle1 = new Rectangle
            {
                LeftDownPointer = (rec1[0], rec1[1]),
                RightTopPointer = (rec1[2], rec1[3]),
                CoordinatesX = (rec1[0], rec1[2]),
                CoordinatesY = (rec1[1], rec1[3])
            };
            var rectangle2 = new Rectangle
            {
                LeftDownPointer = (rec2[0], rec2[1]),
                RightTopPointer = (rec2[2], rec2[3]),
                CoordinatesX = (rec2[0], rec2[2]),
                CoordinatesY = (rec2[1], rec2[3])
            };

            return IsMath(rectangle1.CoordinatesX, rectangle2.CoordinatesX) && IsMath(rectangle1.CoordinatesY, rectangle2.CoordinatesY);
        }
    }
}
