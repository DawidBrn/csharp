using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section17
{
    public interface ICommand
    {
        public string Name { get; }
        void Execute();
    }
    public class HelloCommand : ICommand
    {
        public string Name
        {
            get
            {
                return "Hello";
            }
        }

        public void Execute()
        {
            Console.WriteLine("This is a hello command");
        }
    }
    public class ByeCommand : ICommand
    {
        public string Name
        {
            get
            {
                return "Bye";
            }
        }
        public void Execute()
        {
            Console.WriteLine("This is bye command");
        }
    }
    public class Invoker
    {
        ICommand command = null;
        public ICommand GetCommand(string action)
        {
            switch(action)
            {
                case "Hello":
                    command = new HelloCommand();
                    break;
                case "Bye":
                    command = new ByeCommand();
                    break;
                default:
                    break;

            }
            return command;
        }
    }
}
