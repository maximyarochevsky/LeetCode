using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string str = Convert.ToString(x);
            if (str.Length % 2 == 0)
            {
                for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
                {
                    if (str[i] != str[j])
                    {
                        return false;
                        break;
                    }
                }
                return true;
            }
            else
            {
                for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
                {
                    if (str[i] != str[j])
                    {
                        return false;
                        break;
                    }
                }
                return true;
            }
        }
    }
}
