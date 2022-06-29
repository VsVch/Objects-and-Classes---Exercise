using System;
using System.Collections.Generic;
using System.Linq;

namespace PP07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] info = input.Split();
                string name = info[0];
                string id = info[1];
                int age = int.Parse(info[2]);
                var person = new Person(name, id, age);
                persons.Add(person);
                input = Console.ReadLine();
            }
            foreach (var pers in persons.OrderBy(person => person.Age))
            {
                Console.WriteLine($"{pers.Name} with ID: {pers.ID} is {pers.Age} years old.");
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
        //public override string ToString()
        //{
        //    string piepleView = $"Type: {this.Name} with ID: {this.ID} is {this.Age} years old{Environment.NewLine}";
                              

        //    return piepleView;
        //}
    }
}
