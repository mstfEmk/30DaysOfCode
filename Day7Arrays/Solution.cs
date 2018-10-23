using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Arrays
{
    class Solution
    {

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arrSource = Console.ReadLine().Split(' ');
            string reversedArrayAsString = ReverseArray(arrSource);
            Console.Write(reversedArrayAsString.TrimEnd(' '));
        }

        static int[] ConvertArray(string[] source)
        {
            
            int[] arr = Array.ConvertAll(source, arrTemp => Convert.ToInt32(arrTemp));
            return arr;
        }

        static string ReverseArray(string[] arrSource)
        {
            int[] arr = ConvertArray(arrSource);
            StringBuilder sb = new StringBuilder();
            for (int i = arr.Length - 1; i > -1; i--)
            {
                sb.Append(arr[i] + " ");
            }
            return sb.ToString();
        }
    }
}
