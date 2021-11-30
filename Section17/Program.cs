using System;
using System.Threading;

namespace Section17
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *chain of command
            ContextObject question = new ContextObject { Question = "Who was first on the moon?" };

            ContestantThree number3 = new ContestantThree(null, question);
            ContestantTwo number2 = new ContestantTwo(number3, question);
            ContestantOne number1 = new ContestantOne(number2, question);

            
            number1.HandleRequest(); 

            *command pattern
            Invoker invoker = new Invoker();

            ICommand helloCommand = new ByeCommand();
            helloCommand.Execute();
            
            * observer/listener pattern
            ConreteSubject subject = new ConreteSubject();
            Observer1 observer1 = new Observer1();
            Observer2 observer2 = new Observer2();

            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.Action();
            subject.Action();
            subject.Action();

            subject.Detach(observer2);
            subject.Action();
            **/

            Context StateSwitching = new Context(new InterState1());
            StateSwitching.Request();
            StateSwitching.Request();
            StateSwitching.Request();


        }
    }
}
