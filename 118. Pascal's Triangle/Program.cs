/*
Given an integer numRows, return the first numRows of Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

Example 1:
Input: numRows = 5
Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]

Example 2:
Input: numRows = 1
Output: [[1]]

Constraints:

1 <= numRows <= 30
*/

using _118._Pascal_s_Triangle;

var numRows = 5;
var r = Helper.Generate(numRows);

foreach (var row in r)
{
    Console.WriteLine();
    foreach (var col in r)
    {
        Console.WriteLine(col);
    }
}
Console.WriteLine("Hello, World!");
