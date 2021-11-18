using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Section14
{
    class Person
    {
        public string Name;
        public string Surrname;
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person() {Name = "Jack" , Surrname = " Smith", Age = 10},
                new Person() {Name = "Zackey", Surrname = " Smith" , Age = 20},
                new Person() {Name = "Packi" , Surrname = " Jango", Age = 30},
                new Person() {Name = "Tacky" , Surrname = " Jango", Age = 40},
                new Person() {Name = "Dackie" , Surrname = " Smith", Age = 50}
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
            Console.WriteLine(String.Empty + "\n" + " integers bigger than 2");
            //where syntax
            IEnumerable<int> collectionOfIntegers = numbers.Where(x => x > 2);
            foreach (int i in collectionOfIntegers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(String.Empty + "\n" + " people desc");
            //orderby syntax
            //IOrderedEnumerable<Person> collectionOfNamesAsc = people.OrderBy(x => x.Name);
            foreach (Person i in people.OrderByDescending(x => x.Name))
            {
                Console.Write(i.Name + " ");
            }
            Console.WriteLine(String.Empty + "\n" + "reverse people");

            foreach (int i in numbers2.Reverse())
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(String.Empty + "\n" + " thenby example");

            foreach (Person i in people.OrderBy(x => x.Age).ThenBy(x => x.Name))
            {
                Console.Write(i.Name + " ");
            }
            Console.WriteLine(String.Empty + "\n" + " groupby example");


            IEnumerable<IGrouping<string, Person>> surrnameFilter = people.GroupBy(Person => Person.Surrname);
            foreach(var surrname in surrnameFilter)
            {
                Console.WriteLine(surrname.Key);
            }

            List<int> col1 = new List<int>() { 1, 2 , 3, 4, 5, 6 };
            List<int> col2 = new List<int>() { 1,5, 6 , 7, 8, 9 ,10};
            var innerJoin = col1.Join(col2, x => x, y => y, (x, y) => y);
            
            foreach (int i in innerJoin)
            {
                Console.Write(i + " ");
            }
        }
    }
}
