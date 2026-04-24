namespace _3264._Final_Array_State_After_K_Multiplication_Operations_I
{
    internal static class Helper
    {
        public class Num : IComparable
        {
            public int Position { get; set; }
            public int Value { get; set; }

            public int CompareTo(object? obj)
            {
                if (obj == null) return 1;
                if (this.Value == ((Num)obj).Value)
                {
                    if (this.Position < ((Num)obj).Position)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }

                if (this.Value < ((Num)obj).Value)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }

        public static int[] GetFinalState(int[] nums, int k, int multiplier)
        {
            var dict = new PriorityQueue<Num, Num>();
            int i = 0;
            foreach (var num in nums)
            {
                var p = new Num()
                {
                    Position = i,
                    Value = num
                };
                dict.Enqueue(
                    p,
                    p);
                i++;
            }
            i = 0;
            while (i < k)
            {
                var pos = dict.Dequeue();
                pos.Value = pos.Value * multiplier;
                nums[pos.Position] = pos.Value;
                dict.Enqueue(pos, pos);

                i++;
            }

            return nums;
        }
    }
}
