/*
 Given a binary tree, determine if it is height-balanced
A height-balanced binary tree is a binary tree in which the depth of the two subtrees of every node never differs by more than one.

Example 1:
Input: root = [3,9,20,null,null,15,7]
Output: true

Example 2:
Input: root = [1,2,2,3,3,null,null,4,4]
Output: false

Example 3:
Input: root = []
Output: true
 

Constraints:

The number of nodes in the tree is in the range [0, 5000].
-104 <= Node.val <= 104
 */
using _110._Balanced_Binary_Tree;

var tr = new TreeNode(3);
var tr_0_l = new TreeNode(9);
var tr_0_r = new TreeNode(20);
tr.left = tr_0_l;
tr.right = tr_0_r;
var tr_1_l = new TreeNode(15);
var tr_1_r = new TreeNode(7);
tr_0_r.left = tr_1_l;
tr_0_r.right = tr_1_r;

var res = Helper.IsBalanced(tr);
Console.WriteLine(res);
