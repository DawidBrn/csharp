using System;
using System.Collections.Generic;


namespace Section9
{
    //data structures and collections
    class Program
    {
        //arays
        static string[] strings = new string[4] { "z", "a", "f", "k" };
        static string[] strings2 = { "a", "b", " c" };
        static int[] array = new int[3] { 1, 8, 3 };
        //lists
        static List<int> numbers = new List<int>() { 1, 3, 5, 5, 2, 4 };
        //stacks
        static Stack<string> s = new Stack<string>();
        //enum
        enum Weekday { Monday =1 , Tuesday , Wednesday , Thursday , Friday, Saturday , Sunday };
        //linked lists
        static LinkedList<string> linkedList = new LinkedList<string>();

        static void Main(string[] args)
        {
            /*
            //arrays
                Console.WriteLine("Arrays \n ");
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

            //lists
                Console.WriteLine("Lists \n");
                // Console.WriteLine(numbers.Count);
                    numbers.Capacity = 12;
                    numbers.Add(9);
                List<int> range = new List<int>() { 11, 10 };
                    numbers.AddRange(range);
                        foreach (var integer in numbers)
                            Console.Write(integer + " ");
                    numbers.Sort();
                Console.WriteLine("\n Sorted : ");
                        foreach (var integer in numbers)
                            Console.Write(integer + " ");

                Console.WriteLine(" \n Index of number 9 is : {0}", numbers.BinarySearch(9));

                        numbers.RemoveAt(4);
                Console.WriteLine("Amount of elements in this list is : " + numbers.Count);
                        numbers.Insert(numbers.Count-1,20) ;
                Console.WriteLine("Amount of elements in this list is : " + numbers.Count);
                        foreach (var integer in numbers)
                            Console.Write(integer + " ");
                Console.WriteLine("\n List in reverse ");
                            numbers.Reverse();
                            foreach (var integer in numbers)
                                Console.Write(integer + " ");

                Console.WriteLine("\n Find all odd elements");
                 foreach(var integer in numbers)
                {
                    if (integer % 2 == 1) Console.Write(integer + " ");
                }

            //stacks
            Console.WriteLine("\n Stacks \n");
            s.Push("a");
            s.Push("z");
            Console.WriteLine(s.Peek());
            Console.WriteLine("Checking to strings of braces to guarantee proper code execution");
            Console.WriteLine(IsBalanced("{{[]}}").ToString());
            Console.WriteLine(IsBalanced("{(]}").ToString());
                 
            //enums
            Console.WriteLine("\n Enums \n");

            foreach (var day in Enum.GetNames(typeof(Weekday)))
            {
                Console.WriteLine(day);
            }
            
            //dictionaries

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("key1", "value1");
            dictionary.Add("key2", "value2");
            dictionary.Add("key3", "value3");
            foreach (var key in dictionary)
                Console.WriteLine(key);

            string value = " ";
            dictionary.TryGetValue("key2", out value);
            */
            //linkedlist

            linkedList.AddFirst("root");
            linkedList.AddAfter(linkedList.First, "1st element");
            linkedList.AddAfter(linkedList.Last, "2nd element");
            linkedList.AddBefore(linkedList.First, "new root");
            linkedList.AddLast("last element");

            Console.WriteLine(linkedList.Count);
            

        }

        private static bool IsBalanced(string inputString)
        {
            Stack<char> stackOfClosingBraces = new Stack<char>();
            Stack<char> stackOfOpeningBraces = new Stack<char>();

            foreach (char c in inputString)
            {
                if (c == '}' || c == ']' || c==')')
                {
                    stackOfClosingBraces.Push(c);
                }

            }

            for(int i = inputString.Length -1; i>= 0;i--)
            {
                if (inputString[i] == '{' || inputString[i] == '[' || inputString[i] == '(')
                {
                    stackOfOpeningBraces.Push(inputString[i]);
                }
            }

            if ((stackOfClosingBraces.Count + stackOfOpeningBraces.Count) % 2 != 0)
                return false;
            while (stackOfClosingBraces.Count != 0)
            {
                char currentClosingBrace = stackOfClosingBraces.Pop();
                char currentOpeningBrace = stackOfOpeningBraces.Pop();

                if ((currentClosingBrace == '}' && currentOpeningBrace == '{') ||
                   (currentClosingBrace == ']' && currentOpeningBrace == '[') ||
                    (currentClosingBrace == ')' && currentOpeningBrace == '('))
                    continue;
                else
                    return false;
            }

            return true;

        }
    }
}
