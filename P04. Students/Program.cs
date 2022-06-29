using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudent = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < countOfStudent; i++)
            {
                var input = Console.ReadLine().Split();
                string firstname = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);
                Student student = new Student(firstname, lastName, grade);
                students.Add(student);
            }
            students.OrderByDescending(t => t.Grade).ThenBy(t => t.FirstName).ToList();
            List<Student> sortStudent = students.OrderByDescending(t => t.Grade).ThenBy(t => t.FirstName).ThenBy(t => t.LastName).ToList();
            foreach (Student t in sortStudent)
            {
                Console.WriteLine($"{t.FirstName} {t.LastName}: {t.Grade:f2}");
            }
        }
    }
    class Student
    {
        public Student(string firstname, string lastName, double grade)
        {
            FirstName = firstname;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    
    }
}
