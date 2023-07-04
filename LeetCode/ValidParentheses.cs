using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidParentheses
    {
        public static bool IsValid(string str)
        {
            if (str.Where(s => s == '{').Count() != str.Where(s => s == '}').Count())
                return false;
            if (str.Where(s => s == '(').Count() != str.Where(s => s == ')').Count())
                return false;
            if (str.Where(s => s == '[').Count() != str.Where(s => s == ']').Count())
                return false;
            return true;
        }
    }
}
