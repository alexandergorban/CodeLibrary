using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P167_TwoSum2InputArrayIsSorted
{
    public class SolutionTest
    {
        [Fact]
        public void TwoSum()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int sum = 9;

            int[] expected = new int[] { 1, 2 };

            int[] actual = new Solution().TwoSum(nums, sum);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
    }
}
