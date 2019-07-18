using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solution.P101_SymmetricTree
{
    /*
     * 101. Symmetric Tree
     * https://leetcode.com/problems/symmetric-tree/
     * Tree, Depth-first Search, Breadth-first Search
     *
     * Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
     *
     * For example, this binary tree [1,2,2,3,4,4,3] is symmetric:
     *
     *     1
     *    / \
     *   2   2
     *  / \ / \
     * 3  4 4  3
     * But the following [1,2,2,null,3,null,3] is not:
     *    1
     *   / \
     *  2   2
     *   \   \
     *   3    3
     * Note:
     * Bonus points if you could solve it both recursively and iteratively.
     */
    class Solution
    {
        public bool IsSymmetric(int[] values)
        {
            BinaryTree tree = new BinaryTree(values);

            return IsMirror(tree, tree);
        }

        public bool IsMirror(BinaryTree t1, BinaryTree t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null) return false;

            return (t1.Value == t2.Value) && IsMirror(t1.Right, t2.Left) && IsMirror(t1.Left, t2.Right);
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
            this.Value = values[index];

            if (index * 2 + 1 < values.Length)
            {
                this.Left = new BinaryTree(values, index * 2 + 1);
            }

            if (index * 2 + 2 < values.Length)
            {
                this.Right = new BinaryTree(values, index * 2 + 2);
            }
        }
    }
}
