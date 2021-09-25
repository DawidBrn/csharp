using System;

namespace Section2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random xi = new Random();
            int i = xi.Next(1, 11);
            // postfix and prefix operators
                    Console.WriteLine("Addition of " + i);
                    Console.WriteLine($"Postfix addition of {i} : {i++}");
                    Console.WriteLine($"Result : {i}");
                    Console.WriteLine($"Prefix addition of {i} : {++i}");
                    Console.WriteLine("Subtraction of " + i);
                    Console.WriteLine($"Postfix subtraction of {i} : {i--}");
                    Console.WriteLine($"Result : {i}");
                    Console.WriteLine($"Prefix subtraction of {i} : {--i}");
        

        }
    }
}
