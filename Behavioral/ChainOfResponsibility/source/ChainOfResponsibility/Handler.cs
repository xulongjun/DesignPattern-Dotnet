namespace ChainOfResponsibility
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    public abstract class Handler
    {
        protected Handler? successor;
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }
        public abstract void HandleRequest(int request);
    }

    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request is >= 0 and < 10)
            {
                Console.WriteLine("{0} handled request {1}",
                    GetType().Name, request);
            }
            else
            {
                successor?.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request is >= 10 and < 20)
            {
                Console.WriteLine("{0} handled request {1}",
                    GetType().Name, request);
            }
            else
            {
                successor?.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request is >= 20 and < 30)
            {
                Console.WriteLine("{0} handled request {1}",
                    GetType().Name, request);
            }
            else
            {
                successor?.HandleRequest(request);
            }
        }
    }
}
