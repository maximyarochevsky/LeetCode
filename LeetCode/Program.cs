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
        public static void WriteArrayToConsole<T>(T[] array)
        {
            foreach (var value in array)
            {
                Console.Write($"{value} ");
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 4, 0, -4, -2, 2, 5, 2, 0, -8, -8, -8, -8, -1, 7, 4, 5, 5, -4, 6, 6, -3 };
            Console.WriteLine(LongestConsecutive(array));
        }
        public static int LongestConsecutive(int[] nums)
        {

            if (nums == null || nums.Length == 0)
                return 0;
            nums = nums.Distinct().ToArray();

            HashSet<int> result = new HashSet<int>();

            HashSet<int> temp = new HashSet<int>();

            Array.Sort(nums);
            temp.Add(nums[0]);
            result.Add(nums[0]);

            for (int i = 1; i < nums.Length; i++)
            {
                if (Math.Abs(nums[i] - temp.Max()) == 1 && i == nums.Length - 1)
                {
                        temp.Add(nums[i]);
                        if (result.Count() < temp.Count())
                        {
                            result = new HashSet<int>(temp);
                        }
                    
                }
                 else if(Math.Abs(nums[i] - temp.Max()) == 1)
                {
                    temp.Add(nums[i]);
                }
                else
                {
                    if (result.Count() < temp.Count())
                    {
                        result = new HashSet<int>(temp);
                    }
                    temp.Clear();
                    temp.Add(nums[i]);
                }
            }

            return result.Count();
        }
    }
}
