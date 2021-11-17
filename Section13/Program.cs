using System;
using System.Threading;
namespace Section13
{
    class Program
    {
        static void ExampleFunction()
        {
            for(int i = 0; i<1000; i++)
            {
                Console.WriteLine("eh Hello");
            }
        }
        static void Main(string[] args)
        {
            
            Thread t = new Thread(() => { Console.WriteLine("Hello there"); });
            t.Start();
        }
    }
}
