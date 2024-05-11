namespace _292._Nim_Game
{
    internal static class Helper
    {
        public static bool CanWinNim(int n)
        {
            if (n % 4 == 0)
            { return false; }
            return true;
        }
    }
}
