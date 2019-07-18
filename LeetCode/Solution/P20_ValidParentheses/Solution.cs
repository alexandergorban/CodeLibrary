﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solution.P20_ValidParentheses
{
    /* 20. Valid Parentheses
     * https://leetcode.com/problems/valid-parentheses/
     * String, Stack
     *
     * Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
     * The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
     */
    class Solution
    {
        public bool IsValid(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str.ToCharArray())
            {
                if (c == '(')
                {
                    stack.Push(')');
                }
                else if (c == '{')
                {
                    stack.Push('}');
                }
                else if (c == '[')
                {
                    stack.Push(']');
                }
                else if (stack.Count == 0 || stack.Pop() != c)
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
