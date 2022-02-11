using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P35_SearchInsertPosition
{
    public class SolutionTest
    {
        [Fact]
        public void SearchInsertPosition()
        {
            int[] nums1 = new int[] { 1, 3, 5, 6 };
            int target1 = 5;
            int output1 = 2;
            Assert.Equal(output1, Solution.SearchInsertPosition(nums1, target1));

            int[] nums2 = new int[] { 1, 3, 5, 6 };
            int target2 = 2;
            int output2 = 1;
            Assert.Equal(output2, Solution.SearchInsertPosition(nums2, target2));

            int[] nums3 = new int[] { 1, 3, 5, 6 };
            int target3 = 7;
            int output3 = 4;
            Assert.Equal(output3, Solution.SearchInsertPosition(nums3, target3));
        }
    }
}
