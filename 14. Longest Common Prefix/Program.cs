using _14._Longest_Common_Prefix;

/*
 Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters.
 */


//var strs = new string[3] { "dog", "racecar", "car" };
var strs = new string[4] { "flower", "flower" , "flow", "flight" };


var res = Helper.LongestCommonPrefix(strs);

Console.WriteLine(res);
