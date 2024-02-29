namespace _1154._Day_of_the_Year
{
    internal static class Helper
    {
        public static int DayOfYear(string date)
        {
            int yy = int.Parse(date.Split('-')[0].ToString());
            int mm = int.Parse(date.Split('-')[1].ToString());
            int dd = int.Parse(date.Split('-')[2].ToString());

            var datetime = new DateTime(year: yy, month: mm, day: dd);
            return datetime.DayOfYear;
        }
    }
}
