using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3IntrotoConditionalStatements
{
    class Solution
    {
        static void Main(string[] args)
        {
            bool isNumber = Int32.TryParse(Console.ReadLine(), out int n);
            if (!isNumber)
            {
                Console.WriteLine("You must enter a number");
            } else
            {
                if (n < 1 || n > 100)
                {
                    Console.WriteLine("Enter a number between 1-100");
                }
                bool nIsEven = n % 2 == 0;
                bool nIsOdd = n % 2 == 1;

                if (nIsOdd || (nIsEven && (n >= 6 && n<=20))) 
                {
                    Console.WriteLine("Weird");
                } else
                {
                    Console.WriteLine("Not Weird");
                }
            }

        }
    }
}
