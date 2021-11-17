using System;
using System.Collections;
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
                new Person() {Name = "Jackey" , Age = 20},
                new Person() {Name = "Jacki" , Age = 30},
                new Person() {Name = "Jacky" , Age = 40},
                new Person() {Name = "Jackie" , Age = 50}
            };

            int olderPersonHere = people.Select(x => x.Age).Max();
            Console.WriteLine(olderPersonHere);
            List<int> numbers = new List<int>() { 1, 2, 3, 4 , 5 , 10 ,15, 22, 100};
            IEnumerable<float> colletionOfNumbers = numbers.Cast<float>();
            //select syntax
            IEnumerable<int> numbers2 = numbers.Select(x => x * 3);
           foreach(int i in numbers2)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.WriteLine(String.Empty);
            //ofType syntax
            ArrayList collection = new ArrayList() { "a", 1, "abc", 5, "cdf", 6, 2, "b" };
            IEnumerable<string> collectionOfStrings = collection.OfType<string>();
            foreach (string i in collectionOfStrings)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(String.Empty);
            //where syntax
            IEnumerable<int> collectionOfIntegers = numbers.Where(x => x > 2);
            foreach (int i in collectionOfIntegers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(String.Empty);
            //orderby syntax
            IOrderedEnumerable<Person> collectionOfNamesAsc = people.OrderBy(x => x.Name);
            foreach (Person i in collectionOfNamesAsc)
            {
                Console.Write(i.Name + " ");
            }

        }
    }
}
