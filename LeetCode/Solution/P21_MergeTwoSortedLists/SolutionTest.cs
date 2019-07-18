using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P21_MergeTwoSortedLists
{
    public class SolutionTest
    {
        [Fact]
        public void MergeTwoLists()
        {
            LinkedList<int> linkedList1 = new LinkedList<int>();
            LinkedListNode<int> node1 = new LinkedListNode<int>(1);
            LinkedListNode<int> node2 = new LinkedListNode<int>(2);
            LinkedListNode<int> node3 = new LinkedListNode<int>(4);
            linkedList1.AddLast(node1);
            linkedList1.AddLast(node2);
            linkedList1.AddLast(node3);

            LinkedList<int> linkedList2 = new LinkedList<int>();
            LinkedListNode<int> node4 = new LinkedListNode<int>(1);
            LinkedListNode<int> node5 = new LinkedListNode<int>(3);
            LinkedListNode<int> node6 = new LinkedListNode<int>(4);
            linkedList2.AddLast(node4);
            linkedList2.AddLast(node5);
            linkedList2.AddLast(node6);

            Assert.Equal(1, new Solution().MergeTwoLists(linkedList1.First, linkedList2.First).Value);
        }
    }
}
