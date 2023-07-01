using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class RomantoInteger
    {
        public static int RomanToInt(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length;)
            {
                if (s.Length - i > 1)
                {
                    if (s[i] == 'I')
                    {
                        if (s[i + 1] == 'V')
                        {
                            i += 2;
                            result += 4;
                        }
                        else if (s[i + 1] == 'X')
                        {
                            i += 2;
                            result += 9;
                        }
                        else
                        {
                            i++;
                            result++;
                        }

                        if (i >= s.Length)
                            return result;
                    }

                    switch (s[i])
                    {
                        case 'V':
                        {
                            i++;
                            result += 5;
                            break;
                        }
                        case 'L':
                        {
                            result += 50;
                            i++;
                                break;
                        }
                        case 'D':
                        {
                            result += 500;
                            i++;
                                break;
                        }
                        case 'M':
                        {
                            result += 1000;
                            i++;
                                break;
                        }
                    }
                    

                    if (s[i] == 'X')
                    {
                        if (s[i + 1] == 'L')
                        {
                            i += 2;
                            result += 40;
                        }
                        else if (s[i + 1] == 'C')
                        {
                            i += 2;
                            result += 90;
                        }
                        else
                        {
                            i++;
                            result += 10;
                        }

                        if (i > s.Length)
                            return result;
                    }

                    if (s[i] == 'C')
                    {
                        if (s[i + 1] == 'D')
                        {
                            i += 2;
                            result += 400;
                        }
                        else if (s[i + 1] == 'M')
                        {
                            i += 2;
                            result += 900;
                        }
                        else
                        {
                            i++;
                            result += 100;
                        }

                        if (i > s.Length)
                            return result;
                    }
                }
                else
                    {
                        switch (s[i])
                        {
                            case 'I':
                            {
                                result += 1;
                                i++;
                                break;
                            }
                            case 'V':
                            {
                                result += 5;
                                i++;
                                break;
                            }
                            case 'X':
                            {
                                result += 10;
                                i++;
                                break;
                            }
                            case 'L':
                            {
                                result += 50;
                                i++;
                                break;
                            }
                            case 'C':
                            {
                                result += 100;
                                i++;
                                break;
                            }
                            case 'D':
                            {
                                result += 500;
                                i++;
                                break;
                            }
                            case 'M':
                            {
                                result += 1000;
                                i++;
                                break;
                            }
                        }
                    }
            }

            return result;
        }
    }

    public class Program{
        static void Main(string[] args)
        {
            
            string str = Console.ReadLine();
            Console.WriteLine(RomantoInteger.RomanToInt(str));
        }
    }
}
