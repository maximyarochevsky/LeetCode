using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;

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
          ListNode first = new ListNode()
          {
              value = 1,
              next = new ListNode()
              {
                  value = 1,
                  next = new ListNode()
                  {
                      value = 2,
                      next = new ListNode()
                      {
                          value = 2,
                          next = null,
                      }
                  }
              }
          };

          ListNode withoutDuplicates = DeleteDuplicates(first);

              Console.WriteLine(withoutDuplicates.value);
              Console.WriteLine(withoutDuplicates.next.value);
        }
    }

}
