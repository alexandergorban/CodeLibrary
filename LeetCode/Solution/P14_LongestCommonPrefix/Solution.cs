using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solution.P14_LongestCommonPrefix
{
    /* 14. Longest Common Prefix
     https://leetcode.com/problems/longest-common-prefix/
     * string
     *
     * Write a function to find the longest common prefix string amongst an array of strings.
     * If there is no common prefix, return an empty string "".

     * Example 1:
     * Input: strs = ["flower","flow","flight"]
     * Output: "fl"

     * Example 2:
     * Input: strs = ["dog","racecar","car"]
     * Output: ""
     * Explanation: There is no common prefix among the input strings.
 

     * Constraints:
     * 1 <= strs.length <= 200
     * 0 <= strs[i].length <= 200
     * strs[i] consists of only lower-case English letters.
     */
    class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                prefix = GetCommonPrefix(prefix, strs[i]);

                if (prefix.Length == 0)
                {
                    return "";
                }
            }

            return prefix;
        }

        private string GetCommonPrefix(string first, string second)
        {
            int length = Math.Min(first.Length, second.Length);

            if (length == 0)
            {
                return "";
            }

            int i = 0;

            while (i < length && first[i] == second[i])
            {
                i++;
            }

            return first.Substring(0, i);
        }
    }
}
