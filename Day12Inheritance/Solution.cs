using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Inheritance
{
    class Solution
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = int.Parse(inputs[2]);

            int numScores = int.Parse(Console.ReadLine());
            int[] scores = new int[numScores];

            inputs = Console.ReadLine().Split();
            for(int i = 0; i < numScores; i++)
            {
                scores[i] = int.Parse(inputs[i]);
            }

            Student student = new Student(firstName, lastName, id, scores);
            student.PrintPerson();
            Console.WriteLine("Grade: {0}", student.Calculate());
            

        }
    }

    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person(string firstName, string lastName, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        } 

        public void PrintPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }

    }

    class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
        {
            this.testScores = scores;
        }

        public char Calculate()
        {
            double average = testScores.Average();
            char grade = 'T'; // average < 40

            if (average >= 90)
            {
                grade = 'O';
            } else if (average >= 80)
            {
                grade = 'E';
            }
            else if (average >= 70)
            {
                grade = 'A';
            }
            else if (average >= 55)
            {
                grade = 'P';
            }
            else if (average >= 40)
            {
                grade = 'D';
            }
            return grade;

        }
    }
}
