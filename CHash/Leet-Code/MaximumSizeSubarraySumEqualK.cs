﻿using System;
using System.Collections.Generic;


namespace Leet_Code
{
    class MaximumSizeSubarraySumEqualK
    {
        //        Given an array nums and a target value k, find the maximum length of a subarray that sums to k.If there isn't one, return 0 instead.

        //Note:
        //The sum of the entire nums array is guaranteed to fit within the 32-bit signed integer range.

        //Example 1:

        //Input: nums = [1, -1, 5, -2, 3], k = 3
        //Output: 4 
        //Explanation: The subarray [1, -1, 5, -2] sums to 3 and is the longest.
        //Example 2:

        //Input: nums = [-2, -1, 2, 1], k = 1
        //Output: 2 
        //Explanation: The subarray [-1, 2] sums to 1 and is the longest.
        public static int findMaxSubArraySumEqualsk(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int sum = 0, maxLength = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum == k)
                {
                    maxLength = i + 1;
                }
                if (!map.ContainsKey(sum))
                {
                    map.Add(sum, i);
                }
                if (map.ContainsKey(sum - k))
                {
                    maxLength = Math.Max(maxLength, i - map[sum - k]);
                }
            }

            return maxLength;

        }
    }
}
