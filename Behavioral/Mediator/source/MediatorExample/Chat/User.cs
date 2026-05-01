namespace MediatorExample.Chat;

public sealed class User
{
    private readonly IChatRoomMediator _chat;
    private readonly List<string> _inbox = [];

    public User(string name, IChatRoomMediator chat)
    {
        Name = name;
        _chat = chat;
    }

    public string Name { get; }

    public IReadOnlyList<string> Inbox => _inbox;

    public void Send(string message)
    {
        _chat.Send(this, message);
    }

    public void Receive(User from, string message)
    {
        _inbox.Add($"{from.Name}: {message}");
    }
}

