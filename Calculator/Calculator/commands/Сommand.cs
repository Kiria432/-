using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.commands
{
    abstract public class Command
    {
        protected ArithmeticUnit unit;
        protected int operand;
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
