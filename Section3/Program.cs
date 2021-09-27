using System;

namespace Section3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i = rand.Next(1, 6)+1;
            bool temp = nextBoolean(rand);

            switch(i)
            {
                case 1:
                    Console.WriteLine("Monday");
                    if (temp) Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
                    else Console.WriteLine("Meaby next time you'll got to know the date");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    if (temp) Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
                    else Console.WriteLine("Meaby next time you'll got to know the date");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    if (temp) Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
                    else Console.WriteLine("Meaby next time you'll got to know the date");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    if (temp) Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
                    else Console.WriteLine("Meaby next time you'll got to know the date");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    if (temp) Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
                    else Console.WriteLine("Meaby next time you'll got to know the date");
                    break;
                default:
                    Console.WriteLine("error accured");
                    break;
            }

           


        }
        static bool nextBoolean(Random rand)
        {
            return rand.Next() > (Int32.MaxValue / 2);
        }
    }
}
