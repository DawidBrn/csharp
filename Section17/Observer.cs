using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section17
{
     public interface IObserver
    {
        public void Update(ISubject subject);
    }
    public interface ISubject
    {
        public void Attach(IObserver observer);
        public void Detach(IObserver observer);
        public void Notify();
    }
    public class ConreteSubject : ISubject
    {
        public int State { get; set; }
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("I just attached new observer to this subject");
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine("I just detached an observer from this subject");
            observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("I'm notifying all observers subscribed to this event");
            foreach(var observer in observers)
            {
                observer.Update(this);
            }
        }

        public void Action()
        {
            State = new Random().Next(0,100);
            Console.WriteLine("Action genarated : " + State + " number");
            Notify();
        }
    }
    public class Observer1 : IObserver
    {
        public void Update(ISubject subject)
        {
            //trigger for this observer
            if ((subject as ConreteSubject).State % 5 == 0)
            { 
                Console.WriteLine("Observer1 is interested in this event");
            }

        }
    }
    public class Observer2 : IObserver
    {
        public void Update(ISubject subject)
        {
            //trigger for this observer
            if ((subject as ConreteSubject).State % 3 == 0)
            {
                
                Console.WriteLine("Observer2 is interested in this event");
            }

        }
    }
}
