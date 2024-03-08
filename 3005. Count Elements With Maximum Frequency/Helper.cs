namespace _3005._Count_Elements_With_Maximum_Frequency
{
    internal static class Helper
    {
        public static int MaxFrequencyElements(int[] nums)
        {
            var resArr = new int[101];
            for (int i = 0; i < nums.Length; i++)
            {
                resArr[nums[i]]++; 
            }
            Array.Sort(resArr);
            int r = 0;
            for (int i = resArr.Length-1; i>=0; i--)
            {
                r = r + resArr[i];
                if (resArr[i] == resArr[i-1])
                { 
                    continue;
                }
                break;
            }
            return r;
        }
    }
}
