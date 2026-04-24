/*
 633. Sum of Square Numbers
Medium
Topics
Companies
Given a non-negative integer c, decide whether there're two integers a and b such that a2 + b2 = c.

Example 1:
Input: c = 5
Output: true
Explanation: 1 * 1 + 2 * 2 = 5

Example 2:
Input: c = 3
Output: false

Constraints:

0 <= c <= 231 - 1
 */
using _633._Sum_of_Square_Numbers;

var c = 2147483600;
var r = Helper.JudgeSquareSum(c);

Console.WriteLine(r);
