using System;

namespace Section8
{
    class Program : IExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
}
