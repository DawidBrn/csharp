using System;


namespace Section9
{
    //data structures and collections
    class Program
    {
        static string[] strings = new string[4] { "z", "a", "f", "k" };
        static string[] strings2 = { "a", "b", " c" };
        static int[] array = new int[3] { 1, 8, 3 };

        static void Main(string[] args)
        {
            string ContentStrings = "";
            foreach(var letter in strings)
            {
                ContentStrings += (letter.ToString() + " " );
            }
            Console.WriteLine(ContentStrings);
            ContentStrings = "";
            Array.Sort(strings);
            foreach (var letter in strings)
            {
                ContentStrings += (letter.ToString() + " ");
            }
            Console.WriteLine(ContentStrings);
        }
    }
}
