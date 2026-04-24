/*
You are given an array of strings words and a string pref.
Return the number of strings in words that contain pref as a prefix.
A prefix of a string s is any leading contiguous substring of s. 

Example 1:
Input: words = ["pay","attention","practice","attend"], pref = "at"
Output: 2
Explanation: The 2 strings that contain "at" as a prefix are: "attention" and "attend".

Example 2:
Input: words = ["leetcode","win","loops","success"], pref = "code"
Output: 0
Explanation: There are no strings that contain "code" as a prefix.
 
Constraints:

1 <= words.length <= 100
1 <= words[i].length, pref.length <= 100
words[i] and pref consist of lowercase English letters.
 */

using _2185._Counting_Words_With_a_Given_Prefix;

var words = new string[] { "kttxeksggb", "vucqwew", "lyknscc", "mryl", "vwarnwkfmd", "ivawxbntgs", "mylw", "namybmfy", "uosag", "rzernqxyn", "puf", "hfwjnmvm", "jjfyd", "xteybd", "v", "ywntwzn", "npsogop", "brgvlw", "vewhi", "brk", "hheub", "zl", "vt", "bxjtjivep", "p", "io", "xotulskjmt", "mctffonh", "pmeuqhoe", "ghktrtq", "u", "ngnvwan", "pqmlvvhl", "enjf", "qomcejb", "twgqww", "bnilyqy", "nc", "fttlodnz", "fya", "g", "uoivsr", "gtxgcaf", "qs", "gkfl", "sdmacxf", "mzy", "xjv", "yipc", "rctqugjjk", "myij", "xxg", "vyup", "utqxplpsa", "imbteaczlc", "qfgdcz", "atfn", "pxcsg", "f", "omukbiaudb", "uh", "uobwgt", "hgqipk", "zunfzinenk", "i", "p", "pet", "fxai", "ortqpwkukg", "rxgh", "ylfh" };
var pref = "ikwjoty";
var count = Helper.PrefixCount(words, pref);

Console.WriteLine(count);