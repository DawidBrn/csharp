using System;

namespace Section4
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo opt;
            string text,color;
            Console.WriteLine("Hello there! \n 1.Input text \n 2.Color scheme \n 3.Exit ");
            opt = Console.ReadKey();
            if (opt.Key == ConsoleKey.Escape) return;
            else
            while (opt.KeyChar!='3')
            {
                switch (opt.KeyChar)
                {
                    case '1':
                        Console.WriteLine(" \n Write something");
                        text = Console.ReadLine();
                        Console.Clear();
                        for (int i = 0; i < text.Length; i++)
                            Console.Write(text[i] + " | ");
                        return;
                        
                    case '2':
                        
                        return;
                    case '3':
                        break ;
                    default:
                        Console.WriteLine("\n You pressed the wrong button");
                        opt = Console.ReadKey();
                        break;
                }
            }
            Console.Clear();


        }
    }
}
