using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FacadePattern
{
    class CPU
    {
        public void Freeze() 
        {
            Console.WriteLine("CPU run Freeze");
        }
        public void Jump() 
        {
            Console.WriteLine("CPU run Jump");
        }
        public void Execute() 
        {
            Console.WriteLine("CPU run Execute");
        }
    }
}
