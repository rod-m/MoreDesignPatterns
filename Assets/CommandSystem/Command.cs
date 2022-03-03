using UnityEngine;

namespace CommandSystem
{
    public abstract class Command
    {
        public abstract void DoAction();
        public abstract bool isDone { get; }
    }
}
