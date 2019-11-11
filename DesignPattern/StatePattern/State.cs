using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StatePattern
{
    public abstract class State
    {
        protected Context m_Context = null;

        public State(Context theContext)
        {
            this.m_Context = theContext;
        }

        public abstract void Handle(int value);

    }
}
