﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solution.P35_SearchInsertPosition
{
    /*
    35. Search Insert Position
    https://leetcode.com/problems/search-insert-position/
    
    Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

    You must write an algorithm with O(log n) runtime complexity.

    Example 1:
    Input: nums = [1,3,5,6], target = 5
    Output: 2

    Example 2:
    Input: nums = [1,3,5,6], target = 2
    Output: 1

    Example 3:
    Input: nums = [1,3,5,6], target = 7
    Output: 4

    Constraints:
    1 <= nums.length <= 104
    -104 <= nums[i] <= 104
    nums contains distinct values sorted in ascending order.
    -104 <= target <= 104
    */
    static class Solution
    {
        public static int SearchInsertPosition(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int mid = (left + right) / 2;

                if (numbers[mid] > target)
                {
                    right = mid - 1;
                }
                else if (numbers[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            if (numbers[left] < target)
            {
                return left + 1;
            }
            else
            {
                return left;
            }
        }
    }
}
