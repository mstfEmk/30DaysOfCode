using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day112DArrays
{
    class Solution
    {
        static int[,] arrayInput = new int[6, 6];
        static void ReadArrayInput()
        {
            for (int i=0; i < 6; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                for (int j = 0; j < line.Length; j++)
                {
                    arrayInput[i, j] = int.Parse(line[j]);
                }
            }
        }

        static int CalculateSum(int i, int j)
        {
            int topRow = arrayInput[i - 1, j - 1] + arrayInput[i - 1, j] + arrayInput[i - 1, j + 1];
            int currentRow = arrayInput[i, j];
            int bottomRow = arrayInput[i + 1, j - 1] + arrayInput[i + 1, j] + +arrayInput[i + 1, j + 1];
            return topRow + currentRow + bottomRow;
        }

        static void Main(string[] args)
        {
            ReadArrayInput();
            int current, max = int.MinValue; // = 0; it is causing problem when sum is negative
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    current = CalculateSum(i, j);
                    max = Math.Max(max, current);
                }
            }
            Console.WriteLine(max);
        }
    }
}
