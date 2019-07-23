using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solution.P26_RemoveDuplicatesFromSortedArray
{
    /*
     * 26. Remove Duplicates from Sorted Array
     * https://leetcode.com/problems/remove-duplicates-from-sorted-array/
     * Array, Two Pointers
     *
     * Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.
     *
     * Example 1:
     * Given nums = [1,1,2],
     * Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.
     * It doesn't matter what you leave beyond the returned length.
     *
     * Example 2:
     * Given nums = [0,0,1,1,1,2,2,3,3,4],
     * Your function should return length = 5, with the first five elements of nums being modified to 0, 1, 2, 3, and 4 respectively.
     * It doesn't matter what values are set beyond the returned length.
     */
    class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums.Length;
            }

            int i = 1;

            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j - 1] != nums[j])
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            return i;
        }
    }
}
