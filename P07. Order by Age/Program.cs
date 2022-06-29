using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var listPeople = new List<Person>();
            while (input != "End")
            {
                var inputInfo = input.Split();
                var people = new Person();

                people.Name = inputInfo[0];
                people.ID = inputInfo[1];
                people.Age = int.Parse(inputInfo[2]);

                listPeople.Add(people);
                input = Console.ReadLine();


               


            }
            foreach (var person in listPeople.OrderBy(person => person.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }









        }
    }
    public class Person
    {
       
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        

    }

}
