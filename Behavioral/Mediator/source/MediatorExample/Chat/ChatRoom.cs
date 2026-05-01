namespace MediatorExample.Chat;

public sealed class ChatRoom : IChatRoomMediator
{
    private readonly Dictionary<string, User> _usersByName = new(StringComparer.OrdinalIgnoreCase);

    public void Register(User user)
    {
        _usersByName[user.Name] = user;
    }

    public void Send(User from, string message)
    {
        foreach (var user in _usersByName.Values)
        {
            if (ReferenceEquals(user, from))
                continue;

            user.Receive(from, message);
        }
    }
}

