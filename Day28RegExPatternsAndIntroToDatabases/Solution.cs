using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    private static List<string> names = new List<string>();

    static bool IsValid(string firstName, string emailID)
    {
        Match matchFirstName = Regex.Match(firstName, @"([a-z]+)$");
        Match matchEmailID = Regex.Match(emailID, @"([A-Z@.]+)gmail.com$");

        if (matchFirstName.Success && matchEmailID.Success)
            return true;

        return false;
    }

    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstNameEmailID = Console.ReadLine().Split(' ');

            string firstName = firstNameEmailID[0];

            string emailID = firstNameEmailID[1];

            if (IsValid(firstName, emailID))
                names.Add(firstName);

        }

        names.Sort();

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
