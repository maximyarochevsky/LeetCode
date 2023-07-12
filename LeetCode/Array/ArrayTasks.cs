//1.Two Sum
//Easy

//Companies
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//You can return the answer in any order.

//Example 1:

//Input: nums = [2, 7, 11, 15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].
//Example 2:

//Input: nums = [3, 2, 4], target = 6
//Output: [1,2]
//Example 3:

//Input: nums = [3, 3], target = 6
//Output: [0,1]

//Constraints:

//2 <= nums.length <= 104
//- 109 <= nums[i] <= 109
//- 109 <= target <= 109
//Only one valid answer exists.

public class Solution
{
    //easy
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (seen.ContainsKey(complement))
            {
                return new int[] {
                    seen[complement], i
                };
            }
            seen[nums[i]] = i;
        }
        return null; // No solution found
    }
    //easy
    public static int MaxProfit(int[] prices)
    {
        int result = 0;
        int min = prices[0];
        for (int i = 0; i < prices.Length; i++)
        {
            if (min > prices[i])
                min = prices[i];
            else if (result < prices[i] - min)
                result = prices[i] - min;
        }
        return result;
    }
    //medium
    public static int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];

        for (int i = 0, multi = 1; i < nums.Length; i++)
        {
            result[i] = multi;
            multi = multi * nums[i];
        }

        for (int i = nums.Length, multi = 1; i >= 0; i--)
        {
            result[i] = result[i] * multi;
            multi = nums[i] * multi;
        }

        return result;
    }
    // проходим массив таким образов
    // ---------------->
    // <----------------
    // втреча в центре и дополнения слева правых, справа левых
    //public int[] ProductExceptSelf(int[] nums)
    //{
    //    int n = nums.Length;
    //    int[] ans = new int[n];
    //    for (int i = 0; i < n; ++i) ans[i] = 1;

    //    int leftProduct = 1, rightProduct = 1;
    //    for (int i = 1, j = n - 2; i < n; ++i, --j)
    //    {
    //        leftProduct *= nums[i - 1];
    //        rightProduct *= nums[j + 1];
    //        ans[i] *= leftProduct;
    //        ans[j] *= rightProduct;
    //    }

    //    return ans;
    //}

    //medium
    //мое решение
    //public bool IsAnagram(string s, string t)
    //{
    //    List<char> str = s.ToList<char>();

    //    if (s.Length != t.Length)
    //        return false;

    //    for (int i = 0; i < s.Length; i++)
    //    {
    //        if (!str.Contains(t[i]))
    //            return false;
    //        str.Remove(t[i]);
    //    }

    //    return true;
    //}

    //пробуем добавить элемент по ключу - символу строки и по такому же ключу из другой строки
    //прибавляем к этому элементу словаря по этому же ключу 1 и убавляем по этому же ключу из словаря с другой строки 1
    // если во второй строке найдется такой же элемент, то в итоге получится 1-1 = 0 и в конце проверка на все нули

    //через словарь
    //public static bool IsAnagram(string s, string t)
    //{
    //    if (s.Length != t.Length)
    //    {
    //        return false;
    //    }

    //    var symbolFrequency = new Dictionary<char, int>();
    //    for (int i = 0; i < s.Length; i++)
    //    {
    //        symbolFrequency.TryAdd(s[i], 0);
    //        symbolFrequency.TryAdd(t[i], 0);

    //        symbolFrequency[s[i]]++;
    //        symbolFrequency[t[i]]--;
    //    }

    //    return symbolFrequency.Values.All(frequence => frequence == 0);
    //}
    //через сортировку и сравнение двух строк
    public static bool IsAnagram(string s, string t)
    {
        s = String.Concat(s.OrderBy(c => c));
        t = String.Concat(t.OrderBy(c => c));
        return s == t ? true : false;
    }



    //medium

    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            //var c = String.Concat(strs[i].OrderBy(c => c)); - намного медленне, чем сортировка через Arrat.Sort

            char[] arr = strs[i].ToCharArray();
            Array.Sort(arr);
            string c = new string(arr);

            if (dictionary.ContainsKey(c))
                dictionary[c].Add(strs[i]);
            else
            {
                //dictionary[c] = new List<string>() { strs[i] }; - работает медленне, чем создание через Add
                dictionary.Add(c, new List<string>() { strs[i] });
            }
        }

        string[] keys = dictionary.Keys.ToArray();

        return dictionary.Values.ToList();
    }

    //LINQ очень долго
    //public static int[] TopKFrequent(int[] nums, int k)
    //{
    //    return nums.GroupBy(num => num)
    //        .OrderByDescending(num => num.Count())
    //        .Take(k)
    //        .Select(c => c.Key)
    //        .ToArray();
    //}

    //быстрее всего так, через словарь и приоритетную очередь
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
        var res = new int[k];

        foreach (var num in nums)
            if (!dict.TryAdd(num, 1))
                dict[num]++;

        foreach (var pair in dict)
            pq.Enqueue(pair.Key, pair.Value);

        for (int i = 0; i < k; i++)
            res[i] = pq.Dequeue();

        return res;
    }
}