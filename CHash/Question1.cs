using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopcsharp
{
    class Question1
    {
        public int SearchInsert(int[] nums, int target)
        {
            int index = 0;
            if (target <= 0)
            {
                return 0;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i].Equals(target))
                {
                    return index = i;
                }
                else if (Convert.ToInt32(nums[i]) > target)
                {
                    return index = i;
                }
            }
            return index = nums.Length;
        }
    }
}
