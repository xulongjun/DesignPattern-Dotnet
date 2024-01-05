using CommandExample.Command;

namespace CommandExample.Invoker
{
    // Invoker  
    // The Invoker is associated with one or several commands. 
    // It sends a request to the command.
    public class MenuOptions
    {
        private readonly ICommand openCommand;
        private readonly ICommand saveCommand;
        private readonly ICommand closeCommand;
        public MenuOptions(ICommand open, ICommand save, ICommand close)
        {
            openCommand = open;
            saveCommand = save;
            closeCommand = close;
        }
        //The Invoker cannot handle the Request, so it internally calls the Execute Method
        //of the Command Object. 
        public void ClickOpen()
        {
            openCommand.Execute();
        }
        //The Invoker cannot handle the Request, so it internally calls the Execute Method
        //of the Command Object. 
        public void ClickSave()
        {
            saveCommand.Execute();
        }
        //The Invoker cannot handle the Request, so it internally calls the Execute Method
        //of the Command Object. 
        public void ClickClose()
        {
            closeCommand.Execute();
        }
    }
}
