using MediatorExample.Chat;

var chat = new ChatRoom();
var alice = new User("Alice", chat);
var bob = new User("Bob", chat);
var charlie = new User("Charlie", chat);

chat.Register(alice);
chat.Register(bob);
chat.Register(charlie);

alice.Send("Hello everyone!");
bob.Send("Hi Alice!");

Console.WriteLine("Bob inbox:");
Console.WriteLine(string.Join(Environment.NewLine, bob.Inbox));

