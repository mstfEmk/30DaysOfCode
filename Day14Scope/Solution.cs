using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Scope
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public int ComputeDifference()
        {
            int diff = 0;
            for (int i = 0; i < elements.Length-1; i++)
            {
                for (int j = i; j < elements.Length; j++)
                {
                    diff = Math.Abs(elements[i] - elements[j]);
                    if (diff > maximumDifference)
                    {
                        maximumDifference = diff;
                    }
                }
            }

            return maximumDifference;
        }

    }

    class Solution
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);
            d.ComputeDifference();

            Console.WriteLine(d.maximumDifference);

        }
    }
}
