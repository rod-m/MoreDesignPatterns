using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CommandSystem
{
    public abstract class BaseCommandController : MonoBehaviour
    {
        internal Queue<ICommand> _commands = new Queue<ICommand>();
        internal ICommand _currentCommand;
        internal void FindActions()
        {
            if (_currentCommand != null && !_currentCommand.isDone) return;
            if (!_commands.Any()) return;
            _currentCommand = _commands.Dequeue();
            _currentCommand.DoAction();

        }
        internal abstract void DoActions();
        
        void Update()
        {
            FindActions();
            DoActions();
        }
    }
}