namespace _414._Third_Maximum_Number
{
    public class Maximums
    {
        public int? First { get; set; }
        public int? Second { get; set; }
        public int? Third { get; set; }

        public int? GetThirdNotNull()
        {
            if (this.Third != null)
                return this.Third;
            else return this.First;
        }
    }


    internal static class Helper
    {
        private static void SetMaximum(int val, Maximums m)
        {
            if (m.First == val || m.Second == val || m.Third == val)
            {
                return;
            }

            if (val > m.First || m.First == null)
            {
                m.Third = m.Second;
                m.Second = m.First;
                m.First = val;
                return;
            }
            else if (val > m.Second || m.Second == null)
            {
                m.Third = m.Second;
                m.Second = val;
                return;
            }
            else if (val > m.Third || m.Third == null)
            {
                m.Third = val;
            }
        }

        public static int ThirdMax(int[] nums)
        {
            var data = new Maximums();

            foreach (var item in nums)
            {
                if (item > data.Third || data.Third == null)
                {
                    SetMaximum(item, data);
                }
            }

            return (int)data.GetThirdNotNull();
        }
    }
}
