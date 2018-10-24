using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Loops
{
    class Solution
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 2 || n > 20)
            {
                throw new FormatException("n must between 2-20");
            }

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, (n * i));
            }
        }
    }
}
