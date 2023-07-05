using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidParentheses
    {
        //самый простой
        //public bool IsValid(string s)
        //{
        //    while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
        //    {
        //        s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
        //    }

        //    return s.Length == 0;
        //}

        //через стэк моё решение

        //stack.Pop() - Удаляет и возвращает объект, находящийся в начале Stack.
        //stack.Peek() - Возвращает объект, находящийся в начале Stack, без его удаления.
        //stack.Push() - Вставляет объект как верхний элемент стека Stack.

        public static bool IsValid(string str)
        {
            Stack<char> stack = new Stack<char>();
            if (str[0] == '}' || str[0] == ']' || str[0] == ')' || str.Length == 1)
                return false;

            foreach (var symbol in str)
            {
                if (symbol == '{' || symbol == '[' || symbol == '(')
                {
                    stack.Push(symbol);
                }
                switch (symbol)
                    {
                        case '}':
                            if (stack.Count == 0)
                                return false;
                            if (stack.Peek() == '{')
                                stack.Pop();
                            else
                                return false;
                            break;
                        case ']':
                            if (stack.Count == 0)
                                return false;
                        if (stack.Peek() == '[')
                                stack.Pop();
                            else
                                return false;
                            break;
                        case ')':
                            if (stack.Count == 0)
                                return false;
                            if (stack.Peek() == '(')
                                stack.Pop();
                            else
                                return false;
                            break;
                    }
            }
            return stack.Count > 0 ? false : true;
        }
    }
}
