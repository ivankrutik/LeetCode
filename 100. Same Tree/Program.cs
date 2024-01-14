/*
 
Given the roots of two binary trees p and q, write a function to check if they are the same or not.
Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

 
Example 1:
Input: p = [1,2,3], q = [1,2,3]
Output: true

Example 2:
Input: p = [1,2], q = [1,null,2]
Output: false

Example 3:
Input: p = [1,2,1], q = [1,1,2]
Output: false
 

Constraints:

The number of nodes in both trees is in the range [0, 100].
-104 <= Node.val <= 104

 */

using _100._Same_Tree;

TreeNode root = new TreeNode(1);
root.left = new TreeNode(2);
root.right = new TreeNode(3);
root.left.left = new TreeNode(4);
root.left.right = new TreeNode(5);
root.left.right.left = new TreeNode(8);
root.right.left = new TreeNode(6);
root.right.right = new TreeNode(7);
root.right.right.left = new TreeNode(9);
root.right.right.right = new TreeNode(10);

TreeNode root2 = new TreeNode(1);
root2.left = new TreeNode(33);
root2.right = new TreeNode(3);
root2.left.left = new TreeNode(4);
root2.left.right = new TreeNode(5);
root2.left.right.left = new TreeNode(8);
root2.right.left = new TreeNode(6);
root2.right.right = new TreeNode(7);
root2.right.right.left = new TreeNode(9);
root2.right.right.right = new TreeNode(10);

var res = Helper.IsSameTree(root, root2);

Console.WriteLine(res);
