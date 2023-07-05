using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode
    {
       public int value;
       public ListNode next;
       public ListNode(int value = 0, ListNode next = null)
       { 
           this.value = value;
           this.next = next;
       }
    }

    // через рекурсию
    public class MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = new ListNode();

            if(list1 == null)
                return list2;
            if (list2 == null)
                return list1;

            if (list1.value < list2.value)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list2.next, list1);
                return list2;
            }

            return result;
        }
    }
}
