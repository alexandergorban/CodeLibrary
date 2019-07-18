using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P1_TwoSum
{
    public class SolutionTest
    {
        [Fact]
        public void TwoSum()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            Assert.Equal(new int[] { 0, 1 }, new Solution().TwoSum(nums, target));
        }
    }
}
