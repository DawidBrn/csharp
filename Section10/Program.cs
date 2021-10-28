using System;

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
            //Recursion
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
