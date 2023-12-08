
using _1._Two_Sum;

var nums = new int[4] { 2, 7, 11, 15 };
int target = 9;

var res = Helper.TwoSum(nums, target);

foreach (var x in res)
{
    Console.WriteLine(x);
}
