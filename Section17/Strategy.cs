using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section17
{
    public class ContextOfStrategy
    {
        private IStrategy strategy;

        public ContextOfStrategy() { }

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void BusinessLogic()
        {
            var result = strategy.Algorithm(new List<int> { 1, 2, 3, 4, 5 });
            string resultString = string.Empty;
            foreach(int element in result as List<int>)
            {
                resultString += element + " ";
            }
            Console.WriteLine(resultString);
        }
    }
    public interface IStrategy
    {
        object Algorithm(object SetOfData);
    }
    public class ASCLogic : IStrategy
    {
        public object Algorithm(object Data)
        {
            var list = Data as List<int>;
            list.Sort();
            return list;
        }

    }
    public class DSCLogic : IStrategy
    {
        public object Algorithm(object Data)
        {
            Console.WriteLine("Uno reverse");
            var list = Data as List<int>;
            list.Sort();
            list.Reverse();
            return list;
        }

    }
}
