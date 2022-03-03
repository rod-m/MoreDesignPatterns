using System.Collections.Generic;
/*https://csharpindepth.com/articles/singleton*/
namespace CommandSystem
{
    public sealed class CommandStackSingleton
    {
        private static readonly  CommandStackSingleton instance = new CommandStackSingleton();
      
        private Stack<ICommandUndo> _commandHistory = new Stack<ICommandUndo>();

        
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        private CommandStackSingleton()
        {
        }
        public static CommandStackSingleton Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly CommandStackSingleton instance = new CommandStackSingleton();
        }
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