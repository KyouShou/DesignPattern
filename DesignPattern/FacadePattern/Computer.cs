using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FacadePattern
{
    class Computer
    {
        private CPU cpu = null;
        private Memory memory = null;
        private HardDrive hardDrive = null;

        public void StartComputer()
        {
            BootComputer();

            cpu.Freeze();
            cpu.Jump();
            cpu.Execute();
            memory.Load();
            hardDrive.Read();
        }

        private void BootComputer()
        {
            cpu = new CPU();
            memory = new Memory();
            hardDrive = new HardDrive();
        }

    }
}
