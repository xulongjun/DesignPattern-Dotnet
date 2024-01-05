//Create an Instance of Receiver
using CommandExample.Command;
using CommandExample.Invoker;
using CommandExample.Receiver;

Document document = new();
//Create the Command Object by passing the Receiver Instance
ICommand openCommand = new OpenCommand(document);
ICommand saveCommand = new SaveCommand(document);
ICommand closeCommand = new CloseCommand(document);
//Create the Invoker instance by passing the command objects
MenuOptions menu = new(openCommand, saveCommand, closeCommand);
//Giving command to the Invoker to do the operation
menu.ClickOpen();
menu.ClickSave();
menu.ClickClose();