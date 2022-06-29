using System;
using System.Collections.Generic;
using System.Linq;

namespace PP04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);
                var student = new Students(firstName, lastName, grade);
                students.Add(student);
            }
            //students.OrderByDescending(t => t.Grade).ThenBy(t => t.FirstName).ToList();
            List<Students> sort = students.OrderByDescending(t => t.Grade).ThenBy(t => t.FirstName).ThenBy(t => t.LastName).ToList();
            foreach (Students t in sort)
            {
                Console.WriteLine($"{t.FirstName} {t.LastName}: {t.Grade:f2}");
            }

        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public Students(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        //public override string ToString()
        //{
        //    return $"{FirstName} {LastName}: {Grade}";
        //}


    }
}
