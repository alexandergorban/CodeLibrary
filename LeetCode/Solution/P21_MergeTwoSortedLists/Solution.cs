using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solution.P21_MergeTwoSortedLists
{
    /*
     * 21. Merge Two Sorted Lists
     * https://leetcode.com/problems/merge-two-sorted-lists/
     * Linked List
     *
     * Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.
     * Example:
     * Input: 1->2->4, 1->3->4
     * Output: 1->1->2->3->4->4
     */
    class Solution
    {
        public LinkedListNode<int> MergeTwoLists(LinkedListNode<int> l1, LinkedListNode<int> l2)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            while (l1 != null && l2 != null)
            {
                if (l1.Value <= l2.Value)
                {
                    linkedList.AddLast(l1.Value);
                    l1 = l1.Next;
                }
                else
                {
                    linkedList.AddLast(l2.Value);
                    l2 = l2.Next;
                }
            }

            if (l1 != null)
            {
                while (l1.Next != null)
                {
                    linkedList.AddLast(l1.Value);
                    l1 = l1.Next;
                }
            }
            else if (l2 != null)
            {
                while (l2.Next != null)
                {
                    linkedList.AddLast(l2.Value);
                    l2 = l2.Next;
                }
            }

            return linkedList.First;
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var listNode = new ListNode(0);
            var temp = listNode;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    temp.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    temp.next = l2;
                    l2 = l2.next;
                }

                temp = temp.next;
            }

            if (l1 != null)
            {
                temp.next = l1;
            }
            else if (l2 != null)
            {
                temp.next = l2;
            }

            return listNode.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
