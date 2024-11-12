using System;
using System.Collections.Generic;
using System.Linq;

namespace hw
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person_list = new List<Person>()
            {
                new Person(){ Name = "Andrey", Age = 24, City = "Kyiv"},
                new Person(){ Name = "Liza", Age = 18, City = "Odesa" },
                new Person(){ Name = "Oleg", Age = 15, City = "London" },
                new Person(){ Name = "Sergey", Age = 55, City = "Kyiv" },
                new Person(){ Name = "Sergey", Age = 32, City = "Lviv" }
            };

            //1
            // using linq
            var persons_1 = from person in person_list
                            where person.Age > 25
                            select person;

            Console.WriteLine("People older than 25 years:");
            foreach (var person in persons_1)
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old from {person.City}.");
            }

            // using linq extension methods
            var person_1 = person_list.Where(person => person.Age > 25);

            Console.WriteLine("\nPeople older than 25 years:");
            foreach (var person in person_1)
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old from {person.City}.");
            }

            //2
            // using linq
            var persons_2 = from person in person_list
                            where person.City != "London"
                            select person;

            Console.WriteLine("\nPeople not living in London:");
            foreach (var person in persons_2)
            {
                Console.WriteLine($"{person.Name} ({person.Age} years old), residing in {person.City}");
            }

            // using linq extension methods
            var person_2 = person_list.Where(person => person.City != "London");

            Console.WriteLine("\nPeople not living in London");
            foreach (var person in person_2)
            {
                Console.WriteLine($"Name: {person.Name}; Age: {person.Age}; City: {person.City}");
            }

            //3
            // using linq 
            var persons_3 = from person in person_list
                            where person.City == "Kyiv"
                            select person.Name;

            Console.WriteLine("\nNames of people living in Kyiv:");
            foreach (var name in persons_3)
            {
                Console.WriteLine(name);
            }

            // using linq extension methods
            var person_3 = person_list.Where(person => person.City == "Kyiv")
                                      .Select(person => person.Name);

            Console.WriteLine("\nNames of people living in Kyiv:");
            foreach (var name in person_3)
            {
                Console.WriteLine(name);
            }

            //4
            // using linq
            var persons_4 = from person in person_list
                            where person.Age > 35 && person.Name == "Sergey"
                            select person;

            Console.WriteLine("\nPeople older than 35 years named Sergey:");
            foreach (var person in persons_4)
            {
                Console.WriteLine($"{person.Name}, aged {person.Age}, lives in {person.City}.");
            }

            // using linq extension methods
            var person_4 = person_list.Where(person => person.Age > 35 && person.Name == "Sergey");

            Console.WriteLine("\nPeople older than 35 years named Sergey:");
            foreach (var person in person_4)
            {
                Console.WriteLine($"{person.Name}, aged {person.Age}, lives in {person.City}.");
            }

            //5
            // using linq
            var persons_5 = from person in person_list
                            where person.City == "Odesa"
                            select person;

            Console.WriteLine("\nPeople living in Odesa:");
            foreach (var person in persons_5)
            {
                Console.WriteLine($"Resident: {person.Name}; Age: {person.Age}; City: {person.City}");
            }

            // using linq extension methods
            var person_5 = person_list.Where(person => person.City == "Odesa");

            Console.WriteLine("\nPeople living in Odesa:");
            foreach (var person in person_5)
            {
                Console.WriteLine($"Resident: {person.Name}; Age: {person.Age}; City: {person.City}");
            }
            Console.ReadLine();
        }
    }
}
