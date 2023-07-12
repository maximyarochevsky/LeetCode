using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    
    public class Program
    {
        public static void WriteArrayToConsole<T>(T [] array)
        {
            foreach (var value in array)
            {
                Console.Write($"{value} ");
            }
        }


        static void Main(string[] args)
        {
            string[] strs =
            {
                "eat", "tea", "tan", "ate", "nat", "bat"
            };
            IList<IList<string>> list = GroupAnagrams(strs);
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();
            Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
            string[] sortArray = new string[strs.Length];

            for (int i = 0; i < strs.Length; i++)
            {
                sortArray[i] = String.Concat(strs[i].OrderBy(c => c));
            }

            for (int i = 0; i < strs.Length; i++)
            {
                if (dictionary.ContainsKey(sortArray[i]))
                    dictionary[sortArray[i]].Add(strs[i]);
                else
                {
                    dictionary[sortArray[i]] = new List<string>() { strs[i] };
                }
            }

            string[] keys = dictionary.Keys.ToArray();

                result = dictionary.Values.ToList();

                return result;
        }
    }
}
