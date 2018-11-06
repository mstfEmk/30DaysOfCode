using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Sorting
{
    class Solution
    {
        private static int numberOfSwaps;
        private static int[] arr;

        static void Swap(int index0, int index1)
        {
            int tmp = Solution.arr[index0];
            Solution.arr[index0] = Solution.arr[index1];
            Solution.arr[index1] = tmp;
        }

        static void Sort(int n)
        {
            for (int i = 0; i < n; i++)
            {
                // Track number of elements swapped during a single array traversal
                int currentNumberOfSwaps = 0; 

                for (int j = 0; j < (n - 1); j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (Solution.arr[j] > Solution.arr[j+1])
                    {
                        Solution.Swap(j, j + 1);
                        Solution.numberOfSwaps++;
                        currentNumberOfSwaps++;
                    }
                }
                
                // If no elements were swapped during a traversal, array is sorted
                if (currentNumberOfSwaps == 0) 
                {
                    break;
                }

            }

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arrTemp = Console.ReadLine().Split();
            Solution.arr = Array.ConvertAll(arrTemp, Int32.Parse);
            Solution.Sort(n);

            Console.WriteLine("Array is sorted in {0} swaps.", Solution.numberOfSwaps);
            Console.WriteLine("First Element: {0}", Solution.arr[0]);
            Console.WriteLine("Last Element: {0}", Solution.arr[n-1]);

        }
    }
}
