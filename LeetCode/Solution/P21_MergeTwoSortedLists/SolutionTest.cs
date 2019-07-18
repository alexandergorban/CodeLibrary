using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution.P21_MergeTwoSortedLists
{
    public class SolutionTest
    {
        [Fact]
        public void MergeTwoLinkedLists()
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

        [Fact]
        public void MergeTwoLists()
        {
            int[] mergedArrays = new[] { 1, 1, 2, 3, 4, 4 };
            int[] array1 = new[] { 1, 2, 4 };
            int[] array2 = new[] { 1, 3, 4 };

            var listNode1 = new ListNode(0);
            var temp1 = listNode1;

            foreach (var i in array1)
            {
                var t = new ListNode(i);
                temp1.next = t;
                temp1 = t;
            }

            var listNode2 = new ListNode(0);
            var temp2 = listNode2;

            foreach (var i in array2)
            {
                var t = new ListNode(i);
                temp2.next = t;
                temp2 = t;
            }

            var solution = new Solution();
            var result = solution.MergeTwoLists(listNode1.next, listNode2.next);

            foreach (var i in mergedArrays)
            {
                Assert.NotNull(solution);
                Assert.Equal(i, result.val);
                result = result.next;
            }

            Assert.Null(result);
        }
    }
}
