using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int i = 1;

            foreach (int n in nums)
            {
                if (nums[i - 1] != n) nums[i++] = n;
            }

            return i;
        }
    }
}
