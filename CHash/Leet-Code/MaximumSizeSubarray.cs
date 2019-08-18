using System;
using System.Collections.Generic;


namespace Leet_Code
{
    class MaximumSizeSubarray
    {
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
