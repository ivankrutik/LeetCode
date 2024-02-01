namespace _739._Daily_Temperatures
{
    internal static class Helper
    {
        public class tempData
        {
            public int Position { get; set; }
            public int Temper { get; set; }
        }

        public static int[] DailyTemperatures(int[] temperatures)
        {
            var res = new Stack<int>();
            var dict = new Stack<tempData>();
            var dictEnd = new Stack<tempData>();
            tempData val;
            bool isExist;

            for (int i = temperatures.Length - 1; i >= 0; i--)
            {
                isExist = false;
                dictEnd.Clear();
                dict.Push(new tempData() { Position = i, Temper = temperatures[i] });

                while (dict.Any())
                {
                    val = dict.Pop();
                    if (!dictEnd.Any() || dictEnd.Peek().Temper < val.Temper)
                    {
                        dictEnd.Push(val);
                    }

                    if (!isExist && temperatures[i] < val.Temper)
                    { 
                        isExist = true;
                        res.Push(val.Position - i);
                    }

                }
                while (dictEnd.Any())
                {
                    dict.Push(dictEnd.Pop());
                }

                if (!isExist)
                    res.Push(0);
            }
            return res.ToArray();
        }
    }
}
