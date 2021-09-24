using System;

namespace Section1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] x = { 1, 2, 3, 4 };
            int y = 0;
            foreach (int number in x)
            {
                if(y<number) 
                {
                    while (y < number)
                    {
                        Console.Write("Hello World! ");
                        y++;
                        
                    }
                    Console.Write($" y = {y}");
                    y = 0;
                }
                Console.WriteLine(" ");
            }
        }
    }
}
