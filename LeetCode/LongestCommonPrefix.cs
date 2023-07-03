using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestCommonPrefixClass
    {
        public static string ForTwoStrings(string A, string B)
        {
            string str = "";
            for (int i = 0, j = 0; i < A.Length && j < B.Length;)
            {
                
                if (A[i] != B[j])
                {
                    str = "";
                    break;
                }

                str += A[i];
                j++;
                i++;
            }

            return str;
        }


        //public static string LongestCommonPrefix(string[] strs)
        //{
   
         
        //}
    }
}
