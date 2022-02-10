using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solution.P9_PalindromeNumber
{
    /*
    9. Palindrome Number
    https://leetcode.com/problems/palindrome-number/
    Math

    Given an integer x, return true if x is palindrome integer.
    An integer is a palindrome when it reads the same backward as forward.
    For example, 121 is a palindrome while 123 is not.

    Example 1:

    Input: x = 121
    Output: true
    Explanation: 121 reads as 121 from left to right and from right to left.
    Example 2:

    Input: x = -121
    Output: false
    Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
    Example 3:

    Input: x = 10
    Output: false
    Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

    Constraints:
    -231 <= x <= 231 - 1
    Follow up: Could you solve it without converting the integer to a string?
    */
    static class Solution
    {
        public static bool IsPalindromeNumber(int num)
        {
            if (num < 0 || (num != 0 && num % 10 == 0))
            {
                return false;
            }

            int rev = 0;

            while (num > rev)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }

            return (num == rev || num == rev / 10);
        }
    }
}
