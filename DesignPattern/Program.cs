using DesignPattern.StatePattern;
using DesignPattern.StatePattern.ConcreteState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            context.SetState(new ConcreteStateA(context));
            context.Request(5);
            context.Request(15);
            context.Request(25);
            context.Request(35);
            Console.Read();
        }
    }
}
