// Create receiver, command, and invoker
using Command;

ICommand command = new ConcreteCommand();
Invoker invoker = new();
// Set and execute command
invoker.SetCommand(command);
invoker.ExecuteCommand();