using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StatePattern.ConcreteState
{
    public class ConcreteStateC:State
    {
        public ConcreteStateC(Context theContext) : base(theContext) { }

        public override void Handle(int value)
        {
            Console.WriteLine("ConcreteStateC.Handle");

            if (value > 30)
            {
                m_Context.SetState ( new ConcreteStateA(m_Context));
            }
        }
    }
}
