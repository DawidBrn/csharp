using System;
using System.Collections;

namespace Section8
{
    class Employee
    {
        public int Id;

        public Employee(int id)
        {
            this.Id = id;
        }
    }

    class Progream : IComparer
    {


        public int Compare(object x, object y)
        {
            Employee employee1 = (Employee)x;
            Employee empleyee2 = (Employee)y;
            return employee1.Id.CompareTo(empleyee2.Id);
        }

        static void Main(string[] args)
        {
            Employee e1 = new Employee(1);
            Employee e2 = new Employee(2);
            
        }
    }

    /*
    class Program : IExample
    {
        static void Main(string[] args)
        {
            
        }
       
        public void Example()
        {
            Console.WriteLine("hello world!");
        }

        public int Example2()
        {
            return 1;
        }

        public string Example3(string string1, string string2)
        {
            return string1 + " " + string2;
        }
    }

    interface IExample
    {
        void Example();
        int Example2();
        string Example3(string string1, string string2);
    }*/
}
