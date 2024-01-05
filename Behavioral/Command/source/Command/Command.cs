namespace Command
{
    /// <summary>
    /// The 'Command' abstract class
    /// </summary>
    public interface ICommand
    {
        void Execute();
    }
    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    public class ConcreteCommand : ICommand
    {
        //Reference of Receiver Object
        private Receiver receiver => new();

        // Constructor
        public void Execute()
        {
            receiver.Action();
        }
    }
}
