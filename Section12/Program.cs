using System;

namespace Section12
{
    public abstract class Abstract 
    {
        protected int integer1 = 4;
        protected virtual void Print() {
                Console.WriteLine("Abstract says hello");
        }    
    }
    class SuperClass : Abstract
    {
        public SuperClass() { }
       
    }
    class SuperClass2
    {
        protected int integer1 = 7;
        protected virtual void Print()
        {
            Console.WriteLine("SuperClass2 says hello");
        }
    }
    class SubClass : SuperClass2
    {
        protected override void Print()
        {
            Console.WriteLine("Subclass says hello");
        }
    }
    // class subclass : class superclass
    class Program : SubClass
    {
        
        static void Main(string[] args)
        {
            Car.Start();
            Console.WriteLine(Program.MultiplyWithExtras(1, 2));

            Program obj = new Program();
            obj.Print();
            Console.WriteLine(obj.integer1);
        }

        static public class Car
        {
            static int speed;
            static string color;
            static float price;

            static public void Start()
            {
                Console.WriteLine("Car has started");
            }
            static public void Stop()
            {
                Console.WriteLine("Car has stopped");
            }
        }

        public static int number1 = 3;
        public static int number2 = 5;

        public static int MultiplyWithExtras(int num1, int num2 )
        {
            return num1 * num2 + number1 + number2;
        }



    }
}
