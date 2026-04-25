namespace _303._Range_Sum_Query___Immutable
{
    public static class Helper
    {
        static int runningSum = 0;
        static int[]? prefixSum;

        public static void NumArray(int[] nums)
        {
            prefixSum = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                runningSum += nums[i];
                prefixSum[i] = runningSum;
            }
        }

        public static int SumRange(int left, int right)
        {
            if (left == 0)
                return prefixSum[right];

            return prefixSum[right] - prefixSum[left - 1];
        }

    }
}
