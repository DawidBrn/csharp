using System;
using System.Collections.Generic;

namespace Section10
{
    class Program
    {
        delegate void Print();

        private static event EventHandler evt;
        /*
        public static void HandleEvent(object sender, EventArgs evtArgs)
        {
            Console.WriteLine("Hello this is event handler");
        }
        */
        private static Action<int, int> action;

        static void HandleAction(int integer1, int integer2)
        {
            Console.WriteLine(integer1 + integer2);
        }

        static void Main(string[] args)
        {
            //delegates
            /* 
            Print helloWorld = GoodbyeWorld;
            helloWorld();

            Print print = null;
            print += HelloWorld;
            print += GoodbyeWorld;
            print();
            

            //events
            //event to sub += handler method
            evt += (sender, evtArgs) =>
            {
                Console.WriteLine("Hellow this is event handler");
            };
            evt += (sender, evtArgs) =>
            {
                Console.WriteLine("Hellow this is event handler cousin");
            };
            evt.Invoke(null,new EventArgs());
            //Actions
            action += HandleAction;
            action.Invoke(123, 321);
            */
            //Recursion examples
            Console.WriteLine(fib(10));

        }

        static int fib(int n)
        {
            if (n == 0 || n == 1) return n;
            return fib(n - 1) + fib(n - 2);
        }
        //1st disk from 1st to 3rd tower, 2nd disk from 1st to 2nd tower, 1st disk from 3rd tower to 2nd , 3rd disk from 1st to 3rd tower etc.
        static void moveDisk(int n , Stack<int> tower1 , Stack<int> tower2,Stack<int> tower3)
        {
            if(n==1)
            {
                tower3.Push(tower1.Pop());
                return;
            }
            //moving from 1st
            moveDisk(n - 1, tower1, tower2, tower3);
            //moving from 1st to 3rd
            tower3.Push(tower1.Pop());
            //stacking from 2nd
            moveDisk(n - 1, tower2, tower3, tower1);


        }

        /*~Program()
        {
            evt -= HandleEvent;
        }
        */
        static void HelloWorld()
        {
            Console.WriteLine("Hello world!");
        }
        static void GoodbyeWorld()
        {
            Console.WriteLine("Goodbye cruel world");
        }
    }
}
