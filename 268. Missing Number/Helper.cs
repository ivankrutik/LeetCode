namespace _268._Missing_Number
{
    internal static class Helper
    {
        public static int MissingNumber(int[] nums)
        {
            var sum = nums.Length * (nums.Length+1) / 2;
            foreach (var i in nums) 
            {
                sum -= i;
            }
            return sum;
        }
    }
}
