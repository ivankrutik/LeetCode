namespace _349._Intersection_of_Two_Arrays
{
    internal static class Helper
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set = new HashSet<int>();
            var res = new List<int>();
            foreach (int n1 in nums1)
            {
                if (!set.Contains(n1))
                {
                    set.Add(n1);
                }
            }

            foreach (int n2 in nums2)
            {
                if (set.Contains(n2) && !res.Contains(n2))
                {
                    res.Add(n2);
                }
            }
            return res.ToArray();
        }
    }
}
