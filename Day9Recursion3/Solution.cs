using System;

namespace Day9Recursion3
{
    class Solution
    {
        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 2 || n > 12)
            {
                Console.WriteLine("input length must between 2-12");
                return;
            }
            int result = Factorial(n);
            Console.WriteLine(result);

        }
    }
}
