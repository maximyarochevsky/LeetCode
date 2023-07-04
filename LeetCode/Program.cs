using System;
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
            string str1 = "{({[]})}";
            string str2 = "{{{{}}}";
            string str3 = "{]";
            Console.WriteLine(ValidParentheses.IsValid(str1));
            Console.WriteLine(ValidParentheses.IsValid(str2));
            Console.WriteLine(ValidParentheses.IsValid(str3));
        }
    }
}
