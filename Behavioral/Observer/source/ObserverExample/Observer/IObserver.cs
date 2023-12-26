namespace ObserverExample.Observer
{
    // The Observer Interface
    public interface IObserver
    {
        // Receive Notification from Subject
        void Update(string availability);
    }
}
