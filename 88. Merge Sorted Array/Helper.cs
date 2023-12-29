namespace _88._Merge_Sorted_Array
{
    internal static class Helper
    {
        private static int[] Refresh(int[] nums, int position, int value)
        {
            for (int i = nums.Length - 1; i >= position; i--)
            {
                if (i == position)
                {
                    nums[i] = value;
                    break;
                }
                nums[i] = nums[i - 1];
            }
            return nums;
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int j = 0;
            if (n == 0)
            {
                return;
            }
            if (m==0)
            {
                Array.Resize(ref nums1, nums2.Length);
                Array.Copy(nums2, nums1, nums2.Length);
                return;
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] > nums2[j])
                {
                    Refresh(nums1, i, nums2[j]);
                    j++;
                    if (j == n)
                    {
                        return;
                    }
                }
            }

            if (j < n)
            {
                for (int i = 1; i <= n - j; i++)
                {
                    nums1[nums1.Length - i] = nums2[nums2.Length - i];
                }
            }

        }
    }
}
