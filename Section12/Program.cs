using System;

namespace Section12
{
    class Program
    {
        static void Main(string[] args)
        {
            Car.Start();
        }

        static public class Car
        {
            static int speed;
            static string color;
            static float price;

            static public void Start()
            {
                Console.WriteLine("Car has started");
            }
            static public void Stop()
            {
                Console.WriteLine("Car has stopped");
            }
        }
    }
}
