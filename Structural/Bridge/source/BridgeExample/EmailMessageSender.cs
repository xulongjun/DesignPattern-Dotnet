namespace BridgeExample
{
    // This is going to be a class that implements the Implementor Interface i.e. IMessageSender
    // It also provides the implementation details for the associated Abstraction class 
    // Each Concrete Implementation corresponds to a specific platform, in this case sending messages using Email
    public class EmailMessageSender : IMessageSender
    {
        public string MessageTest { get; private set; } = string.Empty;
        public void SendMessage(string Message)
        {
            MessageTest = $"'{Message}' : This Message has been sent using Email";
            Console.WriteLine(MessageTest);
        }
    }
}
