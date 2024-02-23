/*
Given a binary tree, find its minimum depth.
The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
Note: A leaf is a node with no children.

Example 1:
Input: root = [3,9,20,null,null,15,7]
Output: 2

Example 2:
Input: root = [2,null,3,null,4,null,5,null,6]
Output: 5 

Constraints:

The number of nodes in the tree is in the range [0, 105].
-1000 <= Node.val <= 1000
 */

using _111._Minimum_Depth_of_Binary_Tree;

TreeNode root = new TreeNode(3);
root.left = new TreeNode(9);
root.right = new TreeNode(20);
root.right.left = new TreeNode(15);
root.right.right = new TreeNode(7);

TreeNode root2 = new TreeNode(2);
root2.right = new TreeNode(3);
root2.right.right = new TreeNode(4);
root2.right.right.right = new TreeNode(5);
root2.right.right.right.right = new TreeNode(6);

TreeNode root3 = new TreeNode(1);
root3.left = new TreeNode(2);

TreeNode root4 = new TreeNode(1);
root4.left = new TreeNode(2);
root4.right = new TreeNode(3);
root4.left.left = new TreeNode(4);
root4.right.right = new TreeNode(5);

var res = Helper.MinDepth(root4);

Console.WriteLine(res);
