using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FirstIndexOfTheFirstOccurrenceInAString
    {
        public static int StrStr(string haystack, string needle)
        {
            int index = -1;
            int j = 0;

            if (haystack.Contains(needle))
            {
                for (int i = 0; i < haystack.Length && j < needle.Length; i++)
                {
                    if (haystack[i] != needle[j])
                    {
                        if(index != -1)
                            i -= 1;
                        index = -1;
                        j = 0;
                        continue;
                    }
                    if (haystack[i] != needle[j])
                    {
                        index = -1;
                        j = 0;
                        continue;
                    }
                    else if (haystack[i] == needle[needle.Length - 1] && needle.Length == 1)
                        return i;
                    else if (haystack[i] == needle[needle.Length - 1] && index != -1)
                        return index;
                    else if (haystack[i] == needle[j] && index != -1)
                        j++;
                    else
                    {
                        index = i;
                        j++;
                    }
                }
            }

            return index;
        }
    }
}
