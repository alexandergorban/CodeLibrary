using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P11_ContainerWithMostWater
{
    public class SolutionTest
    {
        [Fact]
        public void MaxArea()
        {
            int[] arrInts = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int expectedSquare = 49;

            Assert.Equal(expectedSquare, new Solution().MaxArea(arrInts));
        }
    }
}
