using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P104_MaximumDepthOfBinaryTree
{
    public class SolutionTest
    {
        [Fact]
        public void MaxDepth()
        {
            int[] arrInts = new int[] { 3, 9, 20, 15, 7 };
            BinaryTree tree = new BinaryTree(arrInts);

            Assert.Equal(3, new Solution().MaxDepth(tree));
        }
    }
}
