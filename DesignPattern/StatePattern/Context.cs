using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StatePattern
{
    public class Context
    {
        State m_state = null;

        public void Request(int value)
        {
            m_state.Handle(value);
        }

        public void SetState(State theState)
        {
            Console.WriteLine("Context.SetState:" + theState.GetType().Name);
            m_state = theState;
        }


    }
}
