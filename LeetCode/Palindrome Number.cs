//9. Palindrome Number
//Given an integer x, return true if x is a 
//palindrome, and false otherwise.

//Example 1:

//Input: x = 121
//Output: true
//Explanation: 121 reads as 121 from left to right and from right to left.
//Example 2:

//Input: x = -121
//Output: false
//Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
//Example 3:

//Input: x = 10
//Output: false
//Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 

//Constraints:

//-231 <= x <= 231 - 1
public class Solution {
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
