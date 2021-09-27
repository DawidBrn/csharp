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

            string s = "Lores ipsum"; int temp2 = 0; bool temp3 = nextBoolean(rand);
            do
            {
                for (int x = 0; x < s.Length; x++)
                {
                    for (int y = 0; y < x; y++)
                    {
                        Console.Write("\t");
                    }
                    Console.WriteLine(s[x]);

                }
                for (int j = 0; j < s.Length; j++)
                {
                    for (int k = s.Length - 1; k > j; k--)
                    {
                        Console.Write("\t");
                    }
                    Console.WriteLine(s[s.Length - j - 1]);
                }
                temp2++;
                if (temp2 % 2 == 0) continue;
                if (temp3) { Console.WriteLine("skipped due to unlucky circumstances"); break; }
                Console.WriteLine($"Line nr {temp2}");
            } while (temp2 < s.Length);



        }
        static bool nextBoolean(Random rand)
        {
            return rand.Next() > (Int32.MaxValue / 2);
        }
    }
}
