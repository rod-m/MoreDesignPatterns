namespace CommandSystem
{
    public interface ICommand
    {
        void DoAction();
        bool isDone { get; }
    }
}