using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StatePattern.ConcreteState
{
    public class ConcreteStateB:State
    {
        public ConcreteStateB(Context theContext) : base(theContext) { }

        public override void Handle(int value)
        {
            Console.WriteLine("ConcreteStateB.Handle");

            if (value > 20)
            {
                m_Context.SetState(new ConcreteStateC(m_Context));
            }
        }

    }
}
