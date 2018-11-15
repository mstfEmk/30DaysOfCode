using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29BitwiseAND
{
    class Solution
    {

        static int FindMaxBitwiseAnd(int n, int k)
        {
            int max = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i+1; j <= n; j++)
                {
                    int and = i & j;
                    if (and < k)
                    {
                        max = Math.Max(max, and);
                    }
                    
                }
            }
            return max;
        }


        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int max = FindMaxBitwiseAnd(n, k);

                Console.WriteLine(max);
            }
        }
    }
}
