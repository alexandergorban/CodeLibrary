using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solution.P53_MaximumSubarray
{
    /*
     * 53. Maximum Subarray
     * https://leetcode.com/problems/maximum-subarray/
     * Array, Divide and Conquer, Dynamic Programming
     *
     * Find the contiguous subarray within an array(containing at least one number) which has the largest sum.
     * For example, given the array[-2, 1, -3, 4, -1, 2, 1, -5, 4],
     * the contiguous subarray[4, -1, 2, 1] has the largest sum = 6.
     */
    class Solution
    {
        public int MaxSubArray(int[] array)
        {
            int maxSoFar = array[0];
            int maxEndingHere = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                maxEndingHere = Math.Max(maxEndingHere + array[i], array[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            return maxSoFar;
        }
    }
}
