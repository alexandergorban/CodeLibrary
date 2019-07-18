using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P101_SymmetricTree
{
    public class SolutionTest
    {
        [Fact]
        public void IsSymmetric()
        {
            int[] arrInts1 = new int[] { 1, 2, 2, 3, 4, 4, 3 };
            int[] arrInts2 = new int[] { 1, 2, 2, 3, 4, 3 };

            Assert.True(new Solution().IsSymmetric(arrInts1));
            Assert.False(new Solution().IsSymmetric(arrInts2));
        }
    }
}
