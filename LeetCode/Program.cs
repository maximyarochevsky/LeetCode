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
        public static void WriteArrayToConsole<T>(T[] array)
        {
            foreach (var value in array)
            {
                Console.Write($"{value} ");
            }
        }

        static void Main(string[] args)
        {
            char[][] array = new char[9][];
            
            array[0] = new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'};
            array[1] = new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'};
            array[2] = new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'};
            array[3] = new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'};
            array[4] = new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'};
            array[5] = new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'};
            array[6] = new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'};
            array[7] = new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'};
            array[8] = new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'};

            Console.WriteLine(IsValidSudoku(array));
            Console.WriteLine(1/3);
        }
        public static bool IsValidSudoku(char[][] board)
        {
            HashSet<char>[] row = new HashSet<char>[9];
            HashSet<char>[] col = new HashSet<char>[9];
            HashSet<char>[] sector = new HashSet<char>[9];

            for (int i = 0; i < 9; i++)
            {
                row[i] = new HashSet<char>();
                col[i] = new HashSet<char>();
                sector[i] = new HashSet<char>();
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var elem = board[i][j];
                    if(elem == '.')
                        continue;

                    if (!row[j].Add(elem))
                        return false;

                    if (!col[i].Add(elem))
                        return false;

                    int k = (3 * (i / 3)) + (j / 3);
                    if (!sector[k].Add(elem))
                        return false;
                }
            }

            return true;
        }
    }
}
