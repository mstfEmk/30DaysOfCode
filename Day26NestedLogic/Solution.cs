using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day26NestedLogic
{
    class Solution
    {
        private static CultureInfo cultureInfo = CultureInfo.InvariantCulture;
        static int[] ReadDate()
        {
            string[] input = Console.ReadLine().Split();
            return Array.ConvertAll(input, Int32.Parse);
        }

        static DateTime ReadDate(string input)
        {
            return DateTime.ParseExact(input, "d M yyyy", cultureInfo);
        }

        static int CalculateFine(DateTime actualDate, DateTime expectedDate)
        {
            if (actualDate > expectedDate)
            {
                if (actualDate.Year > expectedDate.Year)
                {
                    return 10000;
                }
                else
                {
                    if (actualDate.Month > expectedDate.Month)
                    {
                        return (actualDate.Month - expectedDate.Month) * 500;
                    }
                    else
                    {
                        if (actualDate.Day > expectedDate.Day)
                        {
                            return (actualDate.Day - expectedDate.Day) * 15;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            return 0;
        }


        static int CalculateFine(int[] actualDate, int[] expectedDate)
        {
            int actualDay = actualDate[0];
            int actualMonth = actualDate[1];
            int actualYear = actualDate[2];

            int expectedDay = expectedDate[0];
            int expectedMonth = expectedDate[1];
            int expectedYear = expectedDate[2];

            if (actualYear < expectedYear)
            {
                expectedMonth += 12;
                if (actualMonth < expectedMonth)
                {
                    expectedDay += 31;
                }
            }

            if (actualYear > expectedYear)
            {
                return 10000;
            }
            else
            {
                if (actualMonth > expectedMonth)
                {
                    return (actualMonth - expectedMonth) * 500;
                }
                else
                {
                    if (actualDay > expectedDay)
                    {
                        return (actualDay - expectedDay) * 15;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

        }

        static void Main(string[] args)
        {
            int[] actualDateArr = ReadDate();
            int[] expectedDateArr = ReadDate();
            Console.WriteLine(CalculateFine(actualDateArr, expectedDateArr));

            // Alternative
            DateTime actualDate = ReadDate(Console.ReadLine());
            DateTime expectedDate = ReadDate(Console.ReadLine());
            Console.WriteLine(CalculateFine(actualDate, expectedDate));

        }
    }
}
