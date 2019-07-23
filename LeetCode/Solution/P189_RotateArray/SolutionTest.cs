using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P189_RotateArray
{
    public class SolutionTest
    {
        [Fact]
        public void Rotate()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;

            int[] target = new int[] { 5, 6, 7, 1, 2, 3, 4 };

            new Solution().Rotate(nums, k);

            for (int i = 0; i < nums.Length; i++)
            {
                Assert.Equal(target[i], nums[i]);
            }
        }
    }
}
