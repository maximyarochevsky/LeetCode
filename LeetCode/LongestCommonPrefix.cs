using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestCommonPrefixClass
    {
        //public static string ForTwoStrings(string A, string B)
        //{
        //    string str = "";
        //    for (int i = 0, j = 0; i < A.Length && j < B.Length;)
        //    {
                
        //        if (A[i] != B[j])
        //        {
        //            str = "";
        //            break;
        //        }

        //        str += A[i];
        //        j++;
        //        i++;
        //    }

        //    return str;
        //}

        public static string ForTwoStrings(string A, string B)
        {
            string result = "";
            string maxResult = "";
            int tempIndex = 0;
            for (int a = 0; a < A.Length; a++)
            {
                int aTemp = a;
                for (int b = 0; b < B.Length && aTemp < A.Length; b++)
                {
                    if (A[aTemp] == B[b])
                    {
                        result += A[aTemp];
                        if (aTemp < A.Length)
                            aTemp++;
                        else
                            break;
                    }
                    else
                    {
                        result = "";
                        aTemp = a;
                    }
                    if (result.Length > maxResult.Length)
                    {
                        maxResult = result;
                    }
                }
                result = "";
            }
            return maxResult;
        }


            public static string LongestCommonPrefix(string[] ss)
            {
                string shortest = ss.OrderBy(s => s.Length).First();

                for (int i = 0; i < shortest.Length; i++)
                {
                    if (ss.Select(s => s[i]).Distinct().Count() > 1) return shortest[..i];
                }

                return shortest;
            }
        

        //public static string LongestCommonPrefix(string[] strs)
        //{
        //    string result = ForTwoStrings(strs[0], strs[1]);

        //    if (result == "")
        //        return result;

        //    string tempResult = "";
            
        //    for (int i = 0; i + 2 < strs.Length; i++)
        //    {
        //        tempResult = ForTwoStrings(strs[i], strs[i + 1]);
        //        if (tempResult == "")
        //            return result;

        //        if (ForTwoStrings(ForTwoStrings(strs[i], strs[i + 1]), ForTwoStrings(strs[i + 1], strs[i + 2])) == "")
        //        {
        //            return "";
        //        }

                

        //        if (tempResult.Length < result.Length)
        //            result = tempResult;

                
        //    }
        //    return result;
        //}
    }
}
