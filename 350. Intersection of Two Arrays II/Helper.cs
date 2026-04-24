namespace _350._Intersection_of_Two_Arrays_II
{
    internal static class Helper
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            nums1 = nums1.Order().ToArray();
            nums2 = nums2.Order().ToArray();

            int p1 = 0;
            int p2 = 0;
            List<int> result = new List<int>();

            while (p1 < nums1.Length && p2 < nums2.Length)
            {
                //equals
                if (nums1[p1] == nums2[p2])
                {
                    result.Add(nums1[p1]);
                    p1++;
                    p2++;
                    continue;
                }

                if (nums1[p1] > nums2[p2])
                {
                    p2++;
                    continue;
                }
                else
                {
                    p1++;
                    continue;
                }
            }

            return result.ToArray();
        }
    }
}
