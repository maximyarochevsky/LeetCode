using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SearchMethods
{
    public class BinarySearch
    {
        public static int BinarySearchMethod(int[] array, int value)
        {
            int center = array.Length / 2;

            if (array[center] == value)
                return center;

            else if (array[center] > value)
            {
                array = array.Take(array.Length/2).ToArray();
                return BinarySearchMethod(array, value);
            }
            else
            {
                array = array.TakeLast(array.Length / 2).ToArray();
                return BinarySearchMethod(array, value);
            }
        }
    }
}
