namespace CommandSystem
{
    public interface ICommandUndo
    {
        void DoAction(); 
        void UnDoAction();
    }
}