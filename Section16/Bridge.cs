using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section16
{
    public abstract class Message
    {
        public ISender Sender { get; set; }
        public string Subject { get; set; }
        public string  Body { get; set; }
        public abstract void Send();
    }

    public class SystemMessage : Message
    {
        public override void Send()
        {
            Sender.SendMessage(Subject, Body);
        }
    }
    public class UserMessage : Message
    {
        public string UserComments { get; set; }

        public override void Send()
        {
            string fullBody = string.Format("{0} - User Comments : {1}", Body, UserComments);
            Sender.SendMessage(Subject, fullBody);
        }
    }
    public interface ISender
    {
        void SendMessage(string subject, string body);
    }
    public class FacebookSender : ISender
    {
        public void SendMessage(string subject , string body)
        {
            Console.WriteLine("Facebook - {0} - {1} ", subject, body);
        }
    }
    public class TwitterSender : ISender
    {
        public void SendMessage(string subject , string body)
        {
            Console.WriteLine("Twitter - {0} - {1} ", subject, body);
        }
    }
    public class NaszaKlasaSender : ISender
    {
        public void SendMessage(string subject , string body)
        {
            Console.WriteLine("Naszaklasa - {0} - {1} ", subject, body);
        }
    }
}
