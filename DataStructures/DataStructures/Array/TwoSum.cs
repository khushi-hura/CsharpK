// ---------------------------------------------------------------------
// <copyright file="TwoSum.cs" owner="khushi-hura">
// Copyright (c) khushi-hura All rights reserved.
// </copyright>
// ---------------------------------------------------------------------

namespace CsharpK.DataStructures.Array
{
    /// <summary>
    /// This class provides solution to 
    /// leetcode problem number 1
    /// <see cref="https://leetcode.com/problems/two-sum/"/>
    /// </summary>
    public class Array
    {
        /// <summary>
        /// Finds the pair which sum to target
        /// </summary>
        /// <param name="nums">Array in which the operation is to be done</param>
        /// <param name="target">Value to which the numbers at 2 resultant indices must sum up to</param>
        /// <returns>Integer array representing two indices whose sum is target</returns>
        public int[] TwoSum(int[] nums, int target)
        {
            int n = nums.Length;
            Dictionary<int, int> idx = new Dictionary<int, int>();

            for (int i = 0; i < n; ++i)
            {
                int diff = target - nums[i];

                if (idx.ContainsKey(diff))
                {
                    return [idx[diff], i];
                }

                idx[nums[i]] = i;
            }

            return [];
        }
    }
}
