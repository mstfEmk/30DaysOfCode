using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1DataTypes
{
    class Solution
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int i2;
            double d2;
            string s2;

            // Read and save an integer, double, and String to your variables.
            i2 = Int32.Parse(Console.ReadLine());
            d2 = Double.Parse(Console.ReadLine());
            s2 = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine("{0}", (i + i2));

            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:0.0}", (d + d2));

            // Concatenate and print the String variables on a new line
            Console.WriteLine(s + s2);
            
            // The 's' variable above should be printed first.
        }
    }
}
