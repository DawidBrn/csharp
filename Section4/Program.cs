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
                            Console.WriteLine("\n g = green , b = blue , r = red , e = exit");
                            color = Console.ReadLine();
                            switch (color)
                            {
                                case "g":
                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                    Console.Clear();
                                    break;
                                case "b":
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.Clear();
                                    break;
                                case "r":
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    break;
                                case "e":
                                    break;
                                default:

                                    break;
                        
                            }
                        return;
                    case '3':
                        break ;
                    default:
                            if (opt.Key == ConsoleKey.Escape) return;
                            Console.WriteLine("\n You pressed the wrong button");
                        opt = Console.ReadKey();
                        break;
                }
            }
            Console.Clear();


        }
    }
}
