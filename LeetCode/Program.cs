using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListNode list13 = new ListNode(4);
            ListNode list12 = new ListNode(2, list13);
            ListNode list1 = new ListNode(1, list12);

            ListNode list23 = new ListNode(4);
            ListNode list22 = new ListNode(3, list13);
            ListNode list2 = new ListNode(1, list12);


            Console.WriteLine(MergeTwoSortedLists.MergeTwoLists(list1, list2));
        }
    }
}
