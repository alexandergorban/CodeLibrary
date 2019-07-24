using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solution.P11_ContainerWithMostWater
{
    /*
     * 11. Container With Most Water
     * https://leetcode.com/problems/container-with-most-water/
     * Array, Two Pointers
     *
     * Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). n vertical lines are drawn
     * such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a container,
     * such that the container contains the most water.
     *
     * Note: You may not slant the container and n is at least 2.
     *
     * Example:
     * Input: [1,8,6,2,5,4,8,3,7]
     * Output: 49
     */
    class Solution
    {
        public int MaxArea(int[] height)
        {
            if (height == null || height.Length < 2)
            {
                return 0;
            }

            int left = 0;
            int right = height.Length - 1;
            int max = 0;

            while (left < right)
            {
                int squareArea = (right - left) * Math.Min(height[left], height[right]);

                if (squareArea > max)
                {
                    max = squareArea;
                }

                if (height[left] <= height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return max;
        }
    }
}
