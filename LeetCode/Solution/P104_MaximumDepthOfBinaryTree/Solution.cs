using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solution.P104_MaximumDepthOfBinaryTree
{
    /*
     * 104. Maximum Depth of Binary Tree
     * https://leetcode.com/problems/maximum-depth-of-binary-tree/
     * Tree, Depth-first Search
     *
     * Given a binary tree, find its maximum depth.
     * The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
     * For example:
     * Given binary tree [3,9,20,15,7],
     * 
     *      3
     *     / \
     *    9  20
     *  /  \
     * 15   7
     *
     * return its depth = 3
     */
    class Solution
    {
        public int MaxDepth(BinaryTree tree)
        {
            if (tree == null) return 0;

            return 1 + Math.Max(MaxDepth(tree.Left), MaxDepth(tree.Right));
        }
    }

    class BinaryTree
    {
        public int Value;
        public BinaryTree Left;
        public BinaryTree Right;

        public BinaryTree(int[] values) : this(values, 0) { }

        BinaryTree(int[] values, int index)
        {
            Load(this, values, index);
        }

        void Load(BinaryTree tree, int[] values, int index)
        {
            Value = values[index];

            if (index * 2 + 1 < values.Length)
            {
                Left = new BinaryTree(values, index * 2 + 1);
            }

            if (index * 2 + 2 < values.Length)
            {
                Right = new BinaryTree(values, index * 2 + 2);
            }
        }
    }
}
