using DesignPattern.FacadePattern;
using DesignPattern.SingletonPattern;
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
            RunSingletonPattern();

            Console.Read();
        }

        private static void RunStatePattern()
        {
            var context = new Context();
            context.SetState(new ConcreteStateA(context));
            context.Request(5);
            context.Request(15);
            context.Request(25);
            context.Request(35);
            Console.Read();
        }

        private static void RunFacadePattern()
        {
            var user = new User();
            user.UserStartComputer();
        }

        private static void RunSingletonPattern()
        {
            Singleton.Instance.Name = "Hello";
            Singleton.Instance.Name = "World";

            Console.WriteLine(Singleton.Instance.Name);

            //建構子用private層級，使其無法初始化
            //var singleton = new Singleton();

        }
    }
}
