using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FacadePattern
{
    public class User
    {
        public void UserStartComputer()
        {
            Computer facade = new Computer();
            facade.StartComputer();
        }

    }
}
