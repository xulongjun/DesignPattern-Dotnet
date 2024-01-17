namespace BridgeExample
{
    // This is going to be a class that implements the Implementor Interface i.e. IMessageSender
    // It also provides the implementation details for the associated Abstraction class 
    // Each Concrete Implementation corresponds to a specific platform, in this case sending messages using SMS
    public class SmsMessageSender : IMessageSender
    {
        public string MessageTest { get; private set; } = string.Empty;
        public void SendMessage(string Message)
        {
            MessageTest = $"'{Message}' : This Message has been sent using SMS";
            Console.WriteLine(MessageTest);
        }
    }
}
