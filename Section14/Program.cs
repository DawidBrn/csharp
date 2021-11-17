using System;
using System.Collections.Generic;
using System.Linq;

namespace Section14
{
    class Person
    {
        public string Name;
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person() {Name = "Jack" , Age = 10},
                new Person() {Name = "Jacki" , Age = 20},
                new Person() {Name = "Jacke" , Age = 30},
                new Person() {Name = "Jacky" , Age = 40}
            };

            int olderPersonHere = people.Select(x => x.Age).Max();
            Console.WriteLine(olderPersonHere);
        }
    }
}
