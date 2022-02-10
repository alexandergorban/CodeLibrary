using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P9_PalindromeNumber
{
    public class SolutionTest
    {
        [Fact]
        public void PalindromeNumber()
        {
            int number1 = 121;
            bool isPalindromeNumber1 = Solution.IsPalindromeNumber(number1);
            Assert.True(isPalindromeNumber1);

            int number2 = -121;
            bool isPalindromeNumber2 = Solution.IsPalindromeNumber(number2);
            Assert.False(isPalindromeNumber2);

            int number3 = 10;
            bool isPalindromeNumber3 = Solution.IsPalindromeNumber(number3);
            Assert.False(isPalindromeNumber3);
        }
    }
}
