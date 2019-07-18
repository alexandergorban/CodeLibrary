using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P53_MaximumSubarray
{
    public class SolutionTest
    {
        [Fact]
        public void MaxSubArray()
        {
            int[] array = new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            // [4,-1,2,1] has the largest sum = 6.
            int largestSum = 6;

            Assert.Equal(largestSum, new Solution().MaxSubArray(array));
        }
    }
}
