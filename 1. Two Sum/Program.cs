
using _1._Two_Sum;

//var nums = new int[5] { -1, -2, -3, -4, -5 };
var nums = new int[3] { 3, 2, 4 };
int target = 6;

var res = Helper.TwoSum(nums, target);

foreach (var x in res)
{
    Console.WriteLine(x);
}
