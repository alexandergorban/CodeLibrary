using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solution.P7_ReversInteger
{
    /*
     * 7. Reverse Integer
     * https://leetcode.com/problems/reverse-integer/
     * Math
     *
     * Given a 32-bit signed integer, reverse digits of an integer.
     *
     * Example 1:
     * Input: 123
     * Output: 321
     *
     * Example 2:
     * Input: -123
     * Output: -321
     *
     * Example 3:
     * Input: 120
     * Output: 21
     *
     * Note:
     * Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1].
     * For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
     */
    class Solution
    {
        public int Reverse(int x)
        {
            int res = 0;
            int sign = (x < 0) ? -1 : 1;

            x *= sign;

            while (x > 0)
            {
                int rem = x % 10;
                x /= 10;
                double max = (Int32.MaxValue - rem) / 10;

                if (res > max)
                {
                    return 0;
                }

                res = res * 10 + rem;
            }

            return res * sign;
        }
    }
}
