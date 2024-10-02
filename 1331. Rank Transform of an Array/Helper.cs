using System.Linq;

namespace _1331._Rank_Transform_of_an_Array
{
    internal static class Helper
    {
        public static int[] ArrayRankTransform(int[] arr)
        {
            var dict = new List<Tuple<int, int>>();
            for (var i = 0; i < arr.Length; i++)
            {
                dict.Add(new Tuple<int, int>(i, arr[i]));
            }

            var sortedDict = from entry in dict orderby entry.Item2, entry.Item1 ascending select entry;

            var r = sortedDict.ToList();
            var res = new int[r.Count];

            int counter = -1;
            for (var i = 0; i < r.Count; i++)
            {
                if (i > 0 && r[i].Item2 == r[i - 1].Item2)
                {
                    res[r[i].Item1] = counter + 1;
                    continue;
                }
                counter++;
                res[r[i].Item1] = counter + 1;
            }

            return res;
        }
    }
}
