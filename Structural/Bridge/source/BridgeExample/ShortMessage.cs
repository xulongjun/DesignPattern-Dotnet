namespace BridgeExample
{
    // This is going to be a concrete class which inherits from the Abstraction class i.e. AbstractMessage. 
    // This Concrete Abstraction Class implements the operations defined by AbstractMessage class.
    public class ShortMessage : AbstractMessage
    {
        public string MessageTest { get; private set; } = string.Empty;

        //The constructor expected an argument of type object which implements the IMessageSender interface
        public ShortMessage(IMessageSender messageSender)
        {
            //Initialize the super class messageSender variable
            this.messageSender = messageSender;
        }
        public override void SendMessage(string Message)
        {
            if (Message.Length <= 10)
            {
                messageSender.SendMessage(Message);
            }
            else
            {
                MessageTest = "Unable to send the message as length > 10 characters";
                Console.WriteLine(MessageTest);
            }
        }
    }
}
