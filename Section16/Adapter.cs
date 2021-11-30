using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section16
{
    

        class Adaptee
        {
            public string GetRequest()
            {
                return "Request from the client";
            }
        }

        public interface ITarget
        {
            string Request();
        }

        class Adptr : ITarget
        {
            private readonly Adaptee adaptee;

            public Adptr(Adaptee adaptee)
            {
                this.adaptee = adaptee;
            }
            public string Request()
            {
                return $"This is '{this.adaptee.GetRequest()}'";
            }
        }

    
}
