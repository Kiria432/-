using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.commands
{
    public class ArithmeticUnit
    {
        public int Registor {  get; set; }
        public void Run(char operationCode, int operand)
        {
            switch (operationCode)
            {
                case '+':
                    {
                        Registor += operand; break;
                    }
                case '-':
                    {
                         Registor -= operand; break;
                    }
                    case'*':
                    {
                         Registor *= operand; break;
                    }
                case '/':
                    {
                         Registor /= operand; break;
                    }
                default: break;
            }
        }

        internal void Run(int operand)
        {
            throw new NotImplementedException();
        }
    }
}
