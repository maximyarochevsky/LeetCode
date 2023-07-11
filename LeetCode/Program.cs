using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    
    public class Program
    {
        public static void WriteArrayToConsole<T>(T [] array)
        {
            foreach (var value in array)
            {
                Console.Write($"{value} ");
            }
        }

        public static int BinarySearch(int[] array, int value, int start, int end)
        {
            int center = (start+end) / 2;

            if (array[center] == value)
                return center;

            else if (array[center] > value)
            {
                start = 0;
                end = center;
                return BinarySearch(array, value, start, end);
            }
            else
            {
                start = center;
                end = array.Length;
                return BinarySearch(array, value, start, end);
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 1,2,3,4,5,6,7,8};
            Console.WriteLine(BinarySearch(array,6,0,array.Length));
        }
    }
}
