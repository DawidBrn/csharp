using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section16
{
     abstract class Component
    {
        abstract public void AddChild(Component c);
        abstract public void Traverse();
    }

    class File : Component
    {
        private string value = string.Empty;

        public File(string val)
        {
            value = val;
        }

        public override void AddChild(Component c) { }

        public override void Traverse()
        {
            Console.WriteLine("\t This is " + value + "file ");
        }
    }

    class Folder : Component
    {
        private string valeu = string.Empty;
        private List<Component> Components = new List<Component>();

        public Folder (string val)
        {
            valeu = val;
        }
        public override void AddChild(Component c)
        {
            Components.Add(c);
        }

        public override void Traverse()
        {
            Console.WriteLine("This is " + valeu + " folder");
            foreach(Component c in Components)
            {
                c.Traverse();
            }
        }
    }

}
