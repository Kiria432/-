using Calculator.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    public class Calc
    {
        ArithmeticUnit arithmeticUnit;

        public ArithmeticUnit arthmeticUnit { get; }

        ControlUnit controlUnit;
        public Calc()
        {
            arthmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }
        public int Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Registor;
        }

        public int Add(int operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }
        public int Sub(int operand)
        {
            return Run(new Sub(arithmeticUnit, operand));
        }
        public int Mul(int operand)
        {
            return Run(new Mul(arithmeticUnit, operand));
        }
        public int Div(int operand)
        {
            return Run(new Div(arithmeticUnit, operand));
        }
        public int Undo(int levels)
        {
            controlUnit.UndoCommand(levels);
            return arithmeticUnit.Registor;
        }
        public int Redo(int levels)
        {
            controlUnit.Redo(levels);
            return arithmeticUnit.Registor;
        }
    }
}
