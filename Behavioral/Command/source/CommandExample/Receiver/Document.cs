namespace CommandExample.Receiver
{
    // Receiver Object 
    // The Receiver contains the business logic. 
    // They know how to perform all kinds of operations
    // They Know how to handle the Request i.e. Performing the actual Operation
    public class Document
    {
        public string? MessageTest { get; private set; }
        public void Open()
        {
            MessageTest = "Document Opened";
            Console.WriteLine(MessageTest);
        }
        public void Save()
        {
            MessageTest = "Document Saved";
            Console.WriteLine(MessageTest);
        }
        public void Close()
        {
            MessageTest = "Document Closed";
            Console.WriteLine(MessageTest);
        }
    }
}
