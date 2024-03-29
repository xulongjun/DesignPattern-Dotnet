﻿namespace Decorator
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    public interface IComponent
    {
        public void Operation();
    }

    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}
