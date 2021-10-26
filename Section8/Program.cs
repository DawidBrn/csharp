using System;
using System.Collections;
using System.Collections.Generic;

namespace Section8
{

    class Program : IEnumerator
    {
        List<object> items = new List<object>();
        int current;
        public object Current => items[current];

        public bool MoveNext()
        {
            if (items.Count == 0 || items.Count <= current)
            { return false; } 
            return true;
        }

        public void Reset()
        {
            current = 0;
        }
    }
    /*
    class Wallet : IEnumerable
    {
        Money[] bills = null;
        int openIndex = 0;

        public Wallet()
        {
            bills = new Money[100];
        }
        public void Add(Money bill)
        {
            bills[openIndex] = bill;
            openIndex++;
        }
        public IEnumerator GetEnumerator()
        {
            foreach( Money bill in bills)
            {
                if(bill == null)
                {
                    break;
                }
                yield return bill;
            }
            
        }
    }
    class Money
    {
        public int amount;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wallet wallet = new Wallet();
            wallet.Add(new Money() { amount = 1 });
            wallet.Add(new Money() { amount = 5 });
            wallet.Add(new Money() { amount = 10 });
            wallet.Add(new Money() { amount = 50 });
            wallet.Add(new Money() { amount = 100 });
            foreach(Money money in wallet)
            {
               Console.WriteLine("Bill : {0}" ,money.amount);
            }
        }
    }*/

    /*
    class Employee
    {
        public int Id;

        public Employee(int id)
        {
            this.Id = id;
        }
    }

    class Program : IComparer
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
    }*/

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
    }

    interface IExample
    {
        void Example();
        int Example2();
        string Example3(string string1, string string2);
    }*/
}
