using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SearchMethods
{
    public class BinarySearch
    {
        public static int BinarySearchMethod(int[] array, int value, int start, int end)
        {
            int center = (start + end) / 2;

            if (array[center] == value)
                return center;

            else if (array[center] > value)
            {
                start = 0;
                end = center;
                return BinarySearchMethod(array, value, start, end);
            }
            else
            {
                start = center;
                end = array.Length;
                return BinarySearchMethod(array, value, start, end);
            }
        }
    }
}
