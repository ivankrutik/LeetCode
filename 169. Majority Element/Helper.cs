namespace _169._Majority_Element
{
    internal static class Helper
    {
        public static int MajorityElement(int[] nums)
        {
            int counter = 1;
            int val = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (val != nums[i])
                {
                    counter--;
                    if (counter == 0)
                    {
                        counter = 1;
                        val = nums[i];
                    }
                }
                else
                {
                    counter++;
                }
            }

            return val;
        }
    }
}
