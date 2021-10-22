using System;

namespace Section7
{
    /// <summary>
    /// 1. class constructors and finalizers
    /// </summary>
    public class Example
    {
        int ExampleNum;
        String ExampleName;
        public Example(int num)
        {
            ExampleNum = num;
        }
        public Example(int num , string name)
        {
            ExampleNum = num;
            ExampleName = name;
        }
        public Example() { }
        ~Example() { }
        //3 . attributes examples
        [Obsolete("Oldmethod is obsolete. Please consider using NewMethod")]
        static void OldMethod() { }
        static void NewMethod() { }

        //2. properties 
        private string id;
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public static void Main(String[] args)
        {   // 1.
            Example ex = new Example(2);
            Example ex2 = new Example(6, "Dawid");
            Console.WriteLine(ex.ExampleNum);
            Console.WriteLine(ex2.ExampleNum +" " + ex2.ExampleName);
            //2.
            Example ex3 = new Example();
            ex3.Id = "123";
            Console.WriteLine(ex3.id);
            OldMethod();

            //4.lambda expiressions
            Action process = () =>
            {
                Console.WriteLine("\n Hello world!");
                Console.WriteLine("This is lambda expression example");
            };
            Action<string> process1 = (s) => Console.WriteLine(s);

            process();
            process1("\n Hello lamda expression here");

            Func<int, int, int> multiply = (x, y) => { return x * y; };
            Console.WriteLine("\n " + multiply(5, 9));
    }
    }

    // 3.
    [AttributeUsage(AttributeTargets.All)]
    public class ExampleAttribute : Attribute { }

    class exampleattribute
    {
        [Example]
        private object exampleObj;
    }

    
}
