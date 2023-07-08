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
            int []array = nums.Distinct().ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                nums[i] = array[i];
            }

            return array.Length;
        }
    }
}
