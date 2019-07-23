using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solution.P88_MergeSortedArray
{
    /*
     * 88. Merge Sorted Array
     * https://leetcode.com/problems/merge-sorted-array/
     * Array, Two Pointers
     * 
     * Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
     * The number of elements initialized in nums1 and nums2 are m and n respectively.
     * You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2.
     *
     * Example:
     * Input:
     * nums1 = [1,2,3,0,0,0], m = 3
     * nums2 = [2,5,6],       n = 3
     * Output: [1,2,2,3,5,6]
     */
    class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (nums2.Length == 0)
            {
                return;
            }

            int p = m - 1;
            int q = n - 1;
            int i = m + n - 1;

            while (p >= 0 && q >= 0)
            {
                if (nums1[p] > nums2[q])
                {
                    nums1[i] = nums1[p];
                    p--;
                }
                else
                {
                    nums1[i] = nums2[q];
                    q--;
                }

                i--;
            }

            while (q >= 0)
            {
                nums1[i] = nums2[q];
                q--;
                i--;
            }
        }
    }
}
