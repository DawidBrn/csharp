using System;
using System.Threading;
using System.Net;
using System.Threading.Tasks;

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
        static void Print1()
        {

            for (int i = 0; i <= 50; i++) System.Diagnostics.Debug.WriteLine(i);
        }
        static void Print2()
        {
            for (int i = 0; i <= 50; i++) System.Diagnostics.Debug.WriteLine(i);

        }
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => new WebClient().DownloadFile("http://www.onet.pl", "onet.html"),
                () => new WebClient().DownloadFile("http://www.sports.yahoo.com", "yahoo.html"));
            Parallel.For(0, 50, i => Console.WriteLine(i));
            /*Thread t = new Thread(() => { Console.WriteLine("Hello there"); });
            t.Start();

            Thread t1 = new Thread(() => { Print1(); });
             Thread t2 = new Thread(() => { Print2(); });
            Thread t1 = new Thread(Print1);
            Thread t2 = new Thread(Print2);
            t1.Start();
            t1.Join();
            t2.Start();*/
        }
    }
}
