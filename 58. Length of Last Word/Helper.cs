
namespace _58._Length_of_Last_Word
{
    public static class Helper
    {
        public static int LengthOfLastWord(string s)
        {
            s = s.TrimEnd();
            var arr = s.Split(' ');
            if (arr.LastOrDefault() == null)
            {
                return 0;
            }
            return arr.LastOrDefault().Length;
        }
    }
}
