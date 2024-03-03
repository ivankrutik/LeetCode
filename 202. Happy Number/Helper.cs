namespace _202._Happy_Number
{
    internal static class Helper
    {
        private static bool? IsHappyProp { get; set; }
        private static HashSet<int> Dict = new HashSet<int>();

        private static List<int> GetListNums(int n)
        {
            var nums = new List<int>();
            foreach (var i in n.ToString().ToArray())
            {
                nums.Add(int.Parse(i.ToString()));
            }
            return nums;
        }

        private static void GetSum(List<int> nums)
        {
            if (IsHappyProp != null)
            {
                return;
            }
            var r = 0;
            foreach (var i in nums)
            {
                r = r + i * i;
            }
            if (r == 1)
            {
                IsHappyProp = true;
                return;
            }
            else
            {
                if (Dict.Contains(r))
                {
                    IsHappyProp = false;
                    return;
                }
                Dict.Add(r);
                GetSum(GetListNums(r));
            }
        }

        public static bool IsHappy(int n)
        {
            Dict.Add(n);
            GetSum(GetListNums(n));
            return (bool)IsHappyProp;
        }
    }
}
