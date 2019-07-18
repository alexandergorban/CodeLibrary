using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P70_ClimbingStairs
{
    public class SolutionTest
    {
        [Fact]
        public void ClimbStairs()
        {
            // Input: 2
            // Output: 2
            // Explanation: There are two ways to climb to the top.
            // 1. 1 step + 1 step
            // 2. 2 steps
            int stairCase1 = 2;
            int distinctWays1 = 2;

            Assert.Equal(distinctWays1, new Solution().ClimbStairs(stairCase1));

            // Input: 3
            // Output: 3
            // Explanation: There are three ways to climb to the top.
            // 1. 1 step + 1 step + 1 step
            // 2. 1 step + 2 steps
            // 3. 2 steps + 1 step
            int stairCase2 = 3;
            int distinctWays2 = 3;

            Assert.Equal(distinctWays2, new Solution().ClimbStairs(stairCase2));
        }
    }
}
