using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Section17
{
    public abstract class HandlerBase
    {
        public HandlerBase NextContestant { get; private set; }

        public ContextObject Question { get; private set; }

        public HandlerBase(HandlerBase nextHandler, ContextObject question)
        {
                NextContestant = nextHandler;
                Question = question;
  
        }
        public abstract void HandleRequest();
    }
    public class ContestantOne : HandlerBase
    {
        public ContestantOne(HandlerBase nextHandler, ContextObject question ) : base(nextHandler, question) { }

        public override void HandleRequest()
        {
            Console.WriteLine("Question :" + Question.Question);
            Console.WriteLine("--------------------");
            Console.WriteLine("");
            Thread.Sleep(3000);
            Console.WriteLine("No response from contestant one");
            NextContestant.HandleRequest();
        }
    }
    public class ContestantTwo : HandlerBase
    {
        public ContestantTwo(HandlerBase nextHandler, ContextObject question) : base(nextHandler, question) { }

        public override void HandleRequest()
        {
            Console.WriteLine("Question :" + Question.Question);
            Console.WriteLine("--------------------");
            Console.WriteLine("");
            Thread.Sleep(3000);
            Console.WriteLine("No response from contestant two");
            NextContestant.HandleRequest();
        }
    }
    public class ContestantThree : HandlerBase
    {
        public ContestantThree(HandlerBase nextHandler, ContextObject question) : base(nextHandler, question) { }

        public override void HandleRequest()
        {
            Console.WriteLine("Question :" + Question.Question);
            Console.WriteLine("--------------------");
            Console.WriteLine("");
            Thread.Sleep(3000);
            Console.WriteLine("No response from contestant three");
        }
    }
    public class ContextObject 
    {
        public string Question { get; set; }
    }
}
