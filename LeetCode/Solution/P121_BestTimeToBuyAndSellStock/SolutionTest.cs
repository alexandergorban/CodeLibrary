using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P121_BestTimeToBuyAndSellStock
{
    public class SolutionTest
    {
        [Fact]
        public void MaxProfit()
        {
            int[] arrInts1 = new int[] { 7, 1, 5, 3, 6, 4 };
            int[] arrInts2 = new int[] { 7, 6, 4, 3, 1 };

            Assert.Equal(5, new Solution().MaxProfit(arrInts1));
            Assert.Equal(0, new Solution().MaxProfit(arrInts2));
        }
    }
}
