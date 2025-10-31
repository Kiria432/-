using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.commands
{
    internal class Div : Command
    {
        public Div( ArithmeticUnit unit, int operand)
        {
            this.operand = operand;
            this.unit = unit;
        }

        public override void Execute()
        {
            unit.Run('/', operand);
        }

        public override void UnExecute()
        {
            unit.Run('*', operand);
        }
    }
}
