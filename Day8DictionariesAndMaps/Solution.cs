using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8DictionariesAndMaps
{
    class Solution
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            for(int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine().Split(' ');
                if (inputData.Length != 2)
                {
                    throw new FormatException("Input must be name number. Example: sam 99912222");
                }
                phoneBook.Add(inputData[0], inputData[1]);
            }
            
            // Query
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (phoneBook.ContainsKey(input))
                {
                    Console.WriteLine("{0}={1}", input, phoneBook[input]);
                } else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
