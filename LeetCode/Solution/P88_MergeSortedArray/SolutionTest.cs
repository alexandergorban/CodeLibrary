using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P88_MergeSortedArray
{
    public class SolutionTest
    {
        [Fact]
        public void RemoveDuplicates()
        {
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int m = 3;

            int[] nums2 = new int[] { 2, 5, 6 };
            int n = 3;

            int[] target = new int[] { 1, 2, 2, 3, 5, 6 };

            new Solution().Merge(nums1, m, nums2, n);

            for (int i = 0; i < nums1.Length; i++)
            {
                Assert.Equal(target[i], nums1[i]);
            }
        }
    }
}
