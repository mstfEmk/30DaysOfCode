using System;

namespace Day6LetsReview
{
    class Solution
    {
        static void Main(string[] args)
        {
            // T is number of test cases
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string s = Console.ReadLine();
                if (s.Length < 2 || s.Length > 10000)
                {
                    throw new FormatException("input length must between 2-20000");
                }

                string first = null;
                string second = null;

                for (int j = 0; j < s.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        first += s[j];
                    } else
                    {
                        second += s[j];
                    }
                }
                Console.WriteLine("{0} {1}", first, second);
            }
        }
    }
}
