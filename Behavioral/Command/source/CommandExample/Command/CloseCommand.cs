﻿using CommandExample.Receiver;

namespace CommandExample.Command
{
    //ConcreteCommand C 
    //It defines a binding between a Receiver Object i.e. Document and an Action i.e. Close
    public class CloseCommand : ICommand
    {
        //Reference of Receiver Object
        private readonly Document document;
        //Initializing the Receiver Object using the Constructor
        public CloseCommand(Document doc)
        {
            document = doc;
        }
        //Execute Method will internally call the Receiver Object Close Method
        public void Execute()
        {
            document.Close();
        }
    }
}
