namespace _171._Excel_Sheet_Column_Number
{
    internal static class Helper
    {
        public static int TitleToNumber(string columnTitle)
        {
            int columnNumber= 0;

            for (var i = 0; i < columnTitle.Length; i++)
            {
                var t = Convert.ToInt32(columnTitle[i] + 1) - 65;
                var temp = t * Math.Pow(26, columnTitle.Length - i - 1);
                columnNumber = (int)((int)columnNumber + temp);
            }

            return columnNumber;
        }
    }
}
