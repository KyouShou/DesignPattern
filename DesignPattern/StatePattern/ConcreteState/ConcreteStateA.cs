using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StatePattern.ConcreteState
{
    public class ConcreteStateA:State
    {
        public ConcreteStateA(Context theContext) : base(theContext) { }

        public override void Handle(int value)
        {
            Console.WriteLine("ConcreteStateA.Handle");

            if (value > 10)
            {
                m_Context.SetState(new ConcreteStateB(m_Context));
            }
        }
    }
}
