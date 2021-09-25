using System;
using System.Text;

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
                    Console.WriteLine($"Prefix subtraction of {i} : {--i} \n ");

            //string value modification 
            string s1 = "Hello";
            string s2 = "there";
            string s3 = s1 + " " + s2;
            Console.WriteLine(s3);
            string s4 = s3 + " mate!";
            Console.WriteLine(s4+ "\n");
            if(s3.Equals(s4))
            {
                Console.WriteLine("They're equals!");
            }
            else Console.WriteLine("They're not equals!");

            if (s4.Contains(s3))
                Console.WriteLine("\"True\"");
            else Console.WriteLine("\"False\"");
        
            //String formating examples 
            int beer = 3; float p = 0.045f;
            string date = String.Format("Today is {0:d}, local time is {0:t}", DateTime.Now);
                Console.WriteLine(String.Format("The {0:P} beer costs {1:C} ",p, beer));
                Console.WriteLine(date+"\n");

                StringBuilder strbuilder = new StringBuilder();
                strbuilder.Append("Hey");
                StringBuilder strbuilder2 = strbuilder;
                Console.WriteLine($"Length of {strbuilder} : " +strbuilder.Length);
                    string s = strbuilder.ToString();
                    Console.WriteLine("Uppercase : " +s.ToUpper());
                        strbuilder2.Remove(1, 1);
                        Console.WriteLine(strbuilder2.ToString());
                            strbuilder.Replace(strbuilder.ToString(), "hi");
                            Console.WriteLine(strbuilder.ToString()+ "\n");

            string[] sArray = date.Split(" ");
            foreach(string item in sArray)
            {
                Console.WriteLine(item);
            }

            float f = 7.5f;
            int integer = (int)f;
            Console.WriteLine("\n"+integer);
            object o = integer;
            Console.WriteLine(o);
            var temp = o;
            Console.WriteLine(temp);
            dynamic temp2 = f;
            Console.WriteLine(temp2);
            
        }
    }
}
