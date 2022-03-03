using System.Collections.Generic;

namespace CommandSystem
{
    public class CommandStack
    {
        private Stack<ICommandUndo> _commandHistory = new Stack<ICommandUndo>();

        public void ExecuteCommand(ICommandUndo command)
        {
            command.DoAction();
            _commandHistory.Push(command);
        }

        public void UndoCommand()
        {
            if(_commandHistory.Count <= 0) return;
            _commandHistory.Pop().UnDoAction();
        }
    }
}