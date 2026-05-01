using MediatorExample.Chat;

namespace MediatorExample.Tests;

public class ChatRoomTests
{
    [Fact]
    public void Send_ShouldDeliverMessageToOtherUsersOnly()
    {
        var chat = new ChatRoom();
        var alice = new User("Alice", chat);
        var bob = new User("Bob", chat);

        chat.Register(alice);
        chat.Register(bob);

        alice.Send("Hello");

        Assert.Empty(alice.Inbox);
        Assert.Single(bob.Inbox);
        Assert.Equal("Alice: Hello", bob.Inbox[0]);
    }
}

