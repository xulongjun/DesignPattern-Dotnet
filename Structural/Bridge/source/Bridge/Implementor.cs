namespace Bridge
{
    public interface IImplementor
    {
        public void Operation();
    }

    /// <summary>
    /// The 'ConcreteImplementorA' class
    /// </summary>
    public class ConcreteImplementorA : IImplementor
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
    /// <summary>
    /// The 'ConcreteImplementorB' class
    /// </summary>
    public class ConcreteImplementorB : IImplementor
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}
