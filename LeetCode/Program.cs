﻿using System;
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
            string s1 = "asd";
            string s2 = "as";

            string [] str = new string[]
            {
                "string",
                "str",
                "abdulstr"
            };

            string[] fals = new string[]
            {
                "ring",
                "abdul",
                "mops"
            };

            string[] polu = new string[]
            {
                "ring",
                "in",
                "poms"
            };

            Console.WriteLine(LongestCommonPrefixClass.ForTwoStrings(s1,s2));

            //Console.WriteLine(LongestCommonPrefixClass.LongestCommonPrefix(str));
            //Console.WriteLine(LongestCommonPrefixClass.LongestCommonPrefix(fals));
            //Console.WriteLine(LongestCommonPrefixClass.LongestCommonPrefix(polu));
        }
    }
}