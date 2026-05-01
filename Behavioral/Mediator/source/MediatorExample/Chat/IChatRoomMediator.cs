namespace MediatorExample.Chat;

public interface IChatRoomMediator
{
    void Register(User user);
    void Send(User from, string message);
}

