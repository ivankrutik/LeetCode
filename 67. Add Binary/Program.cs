/*
 Given two binary strings a and b, return their sum as a binary string.

 

Example 1:
Input: a = "11", b = "1"
Output: "100"

Example 2:
Input: a = "1010", b = "1011"
Output: "10101"
 

Constraints:

1 <= a.length, b.length <= 104
a and b consist only of '0' or '1' characters.
Each string does not contain leading zeros except for the zero itself. 
 */

using _67._Add_Binary;

//var a = "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101";
//var b = "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011";

var a = "11";
var b = "1";

var res = Helper.AddBinary(a, b);

Console.WriteLine(res);
