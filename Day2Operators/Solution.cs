using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Operators
{
    class Solution
    {
        static void Main(string[] args)
        {

            double mealCost = Double.Parse(Console.ReadLine());
            int tipPercent = Int32.Parse(Console.ReadLine());
            int taxPercent = Int32.Parse(Console.ReadLine());

            int totalCost = Solve(mealCost, tipPercent, taxPercent);

            Console.WriteLine(totalCost);
        }

        private static int Solve(double mealCost, int tipPercent, int taxPercent)
        {
            double tip = mealCost * tipPercent / 100;
            double tax = mealCost * taxPercent / 100;
            double totalCost = mealCost + tip + tax;
            return Convert.ToInt32(totalCost);
            
        }
    }
}
