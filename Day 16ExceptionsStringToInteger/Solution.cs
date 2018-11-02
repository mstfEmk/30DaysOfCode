using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16ExceptionsStringToInteger
{
    class Solution
    {
        
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            
            try
            {
                int number = int.Parse(s); 
                Console.WriteLine(number);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
