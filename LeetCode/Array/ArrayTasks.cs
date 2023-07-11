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
}