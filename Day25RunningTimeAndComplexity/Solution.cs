using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day25RunningTimeAndComplexity
{
    class Solution
    {
        static bool IsPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            while (T-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string isPrime = (n >=2 && IsPrime(n)) ? "Prime" : "Not prime";
                Console.WriteLine(isPrime);
            }
        }
    }
}
