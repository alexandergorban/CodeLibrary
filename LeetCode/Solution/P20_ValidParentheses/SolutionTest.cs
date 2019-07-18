using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P20_ValidParentheses
{
    public class SolutionTest
    {
        [Fact]
        public void Q20ValidParentheses()
        {
            string str1 = "()[]{}";
            string str2 = "([)]";

            Assert.True(new Solution().IsValid(str1));
            Assert.False(new Solution().IsValid(str2));
        }
    }
}
