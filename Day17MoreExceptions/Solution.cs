using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17MoreExceptions
{
    class Calculator
    {
        public int power(int n, int p)
        {
            if (n < 0 || p < 0)
            {
                throw new ArgumentException("n and p should be non-negative");
            }

            int result = 1;

            for (int i = 0; i < p; i++)
            {
                result *= n;
            }

            return result;
        }

    }

    class Solution
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = calculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                }
                
            }


        }
    }
}
