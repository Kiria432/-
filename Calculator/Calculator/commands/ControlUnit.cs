using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.commands
{
    public class ControlUnit
    {
        public List<Command> commandsList = new List<Command>();
        private int current = 0;
        public void StoreCommand(Command command)
        {
            commandsList.Add(command);
        }

        public void ExecuteCommand()
        {
            commandsList[current].Execute();
            current++;
        }
        public void UndoCommand(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    commandsList[--current].UnExecute();
                }
            }
        }

        public void Redo(int levels)
        {

        }
    }
}
