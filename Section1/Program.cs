using System;

namespace Section1
{
    public class class1 { }

    public class class2 : class1 { }
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
            //comment test
            printMessage("Print test! ");

            //operator is tests
            Boolean b = "123" is string;
            Boolean c = 123 is string;

            Console.WriteLine($" \n Variable b is a string: {b} \n Variable c is a string: {c} ");

            class2 class2Obj = new class2();
            Boolean d = class2Obj is class1;
            Console.WriteLine($" \n Object class2Obj is inherent to class1 : {d}");
            
        }
        static void printMessage(string message)
        {
            Console.WriteLine("\n"+message);
        }
    }
}
