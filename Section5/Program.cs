using System;
using System.IO;
using System.Text;

namespace Section5
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "";
            Console.WriteLine("Name a file to create : ");
            fileName = Console.ReadLine();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\{fileName}example.txt";
            switch(menu())
            {
                case 1:
                    submenu1();
                    break;
                case 2:
                    break;
                default:
                    break;
            }
            
            try
            {
                string line1 = "", line2 = "";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("hello");
                    sw.WriteLine("there");
                    sw.WriteLine("mate");
                }
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                // Create a new file with using to avoid procces overlapping
                /*using (FileStream fs = File.Create(path))
                {
                    // Add some text to file    
                    Console.WriteLine("Add 1st line :");
                    line1 = Console.ReadLine()+ "\n";
                    Byte[] Line1 = new UTF8Encoding(true).GetBytes(line1);
                    fs.Write(Line1, 0, Line1.Length);
                    Console.WriteLine("Add 2nd line :");
                    line2 = Console.ReadLine();
                    byte[] Line2 = new UTF8Encoding(true).GetBytes(line2);
                    fs.Write(Line2, 0, Line2.Length);
                }

                 
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }*/
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

        }
        static int menu()
        {
            int choice;
            Console.WriteLine("1. View all the files");
            Console.WriteLine("2. Create a file ");
            Console.WriteLine("3.Exit");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static void submenu1()
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DirectoryInfo d = new DirectoryInfo(directory);
            FileInfo[] info = d.GetFiles("*example.txt");
            string str = "";
            foreach (FileInfo file in info)
            {
                str += file.Name + "," ;
            }
            Console.Write(str);
        }



    }
}
