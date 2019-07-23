using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P26_RemoveDuplicatesFromSortedArray
{
    public class SolutionTest
    {
        [Fact]
        public void RemoveDuplicates()
        {
            int[] nums1 = new int[] { 1, 1, 2 };
            int target1 = 2;

            Assert.Equal(target1, new Solution().RemoveDuplicates(nums1));

            int[] nums2 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int target2 = 5;

            Assert.Equal(target2, new Solution().RemoveDuplicates(nums2));
        }
    }
}
