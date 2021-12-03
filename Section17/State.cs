 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section17
{
    public class Context
    {
        public IState State { get; set; }
        public int NumberOfS { get; set; }
        public Context( IState newstate)
        {
            State = newstate;
        }
        public void Request()
        {
            State.Handle(this);
        }
    }
    public interface IState
    {
        public void Handle(Context context);
    }
    public class InterState1 :IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("This is initiation of interstate one ");
            Console.WriteLine("Switches so far : " + context.NumberOfS );
            context.NumberOfS++;
            context.State = new InterState2();
        }
    }
    public class InterState2 : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("This is init of interstate 2 \n commencing operations ");
            Console.WriteLine("Switches so far : " + context.NumberOfS);
            context.NumberOfS++;
            context.State = new InterState1();
        }
    }
}
