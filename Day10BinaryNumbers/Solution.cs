using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10BinaryNumbers
{
    class Solution
    {
        static int FindConsecutiveOnes(string binary)
        {
            int count = 0;
            int max = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    count++;
                    if (count > max)
                    {
                        max = count;
                    }
                } else
                {
                    count = 0;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            int count = FindConsecutiveOnes(binary);
            Console.WriteLine(count);

        }
    }
}
