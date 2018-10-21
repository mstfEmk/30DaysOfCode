using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ClassvsInstance
{
    class Person
    {

        public static void Main()
        {
            int personCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < personCount; i++)
            {
                int age = int.Parse(Console.ReadLine());
                Person person = new Person(age);
                person.AmIOld();
                for (int j = 0; j < 3; j++)
                {
                    person.YearPasses();
                }
                person.AmIOld();
                Console.WriteLine();
            }
        }

        public int age;
        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge
            if (initialAge < 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else
            {
                age = initialAge;
            }
        }
        public void AmIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void YearPasses()
        {
            // Increment the age of the person in here
            age++;
        }
    }
}
