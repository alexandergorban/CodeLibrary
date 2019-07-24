using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P7_ReversInteger
{
    public class SolutionTest
    {
        [Fact]
        public void Reverse()
        {
            int input1 = 123;
            int output1 = 321;
            Assert.Equal(output1, new Solution().Reverse(input1));

            int input2 = -123;
            int output2 = -321;
            Assert.Equal(output2, new Solution().Reverse(input2));

            int input3 = 120;
            int output3 = 21;
            Assert.Equal(output3, new Solution().Reverse(input3));
        }
    }
}
