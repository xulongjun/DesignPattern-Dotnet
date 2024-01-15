namespace Decorator
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public abstract class Decorator : IComponent
    {
        public IComponent component;
        public void SetComponent(IComponent component)
        {
            this.component = component;
        }
        public void Operation()
        {
            component?.Operation();
        }
    }

    /// <summary>
    /// The 'ConcreteDecoratorA' class
    /// </summary>
    public class ConcreteDecoratorA : Decorator
    {
        public new void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }

    /// <summary>
    /// The 'ConcreteDecoratorB' class
    /// </summary>
    public class ConcreteDecoratorB : Decorator
    {
        public new void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        private void AddedBehavior()
        {
            // Method intentionally left empty.
        }
    }
}
