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
        public static void ArrayToConsole<T>(T [] array)
        {
            foreach (var value in array)
            {
                Console.Write($"{value} ");
            }
        }
        static void Main(string[] args)
        {
            int[] nums = { -1, 1, 0, -3, 3 };
            int[] answer = ProductExceptSelf(nums);
            ArrayToConsole(answer);
        }
        
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] answer = new int[nums.Length];

            int multiplication = 1;

            List<int> zeros = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeros.Add(i);
                    continue;
                }
                multiplication *= nums[i];
            }

            if (zeros.Count > 1)
            {
                //для заполнения массива одним числов используем цикл for, т.к он в 4 раза быстрее чем Enumerable.Repeat()
                for (int i = 0; i < nums.Length; i++)
                {
                    answer[i] = 0;
                }

            }
            else if (zeros.Count() == 1)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == zeros.First())
                        answer[i] = multiplication - nums[i];
                    else
                        answer[i] = 0;
                }
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    answer[i] = multiplication - nums[i];
                }
            }

            return answer;
        }
    }
}
