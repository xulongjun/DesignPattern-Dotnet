namespace Bridge
{
    public class Abstraction
    {
        protected IImplementor? implementor;

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementor implementor)
        {
            this.implementor = implementor;
        }
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
