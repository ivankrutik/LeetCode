namespace _168._Excel_Sheet_Column_Title
{
    using System.Text;

    internal static class Helper
    {
        public static string ConvertToTitle(int columnNumber)
        {
            var revers = string.Empty;
            StringBuilder res = new StringBuilder();
            while (columnNumber > 0)
            {
                revers += Convert.ToChar((columnNumber - 1) % 26 + 65);
                columnNumber = (columnNumber - 1) / 26;
            }
            for (var i = revers.Length - 1; i >= 0; i--)
            {
                res.Append(revers[i]);
            }

            return res.ToString();
        }
    }
}
