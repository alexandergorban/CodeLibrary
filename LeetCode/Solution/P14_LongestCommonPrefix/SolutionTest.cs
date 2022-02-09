using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P14_LongestCommonPrefix
{
    public class SolutionTest
    {
        [Fact]
        public void LongestCommonPrefix()
        {
            string[] strs = new string[] { "flower", "flow", "flight" };
            string target = "fl";
            Assert.Equal(target, new Solution().LongestCommonPrefix(strs));

            string[] strs2 = new string[] { "dog", "racecar", "car" };
            string target2 = "";
            Assert.Equal(target2, new Solution().LongestCommonPrefix(strs2));
        }
    }
}
