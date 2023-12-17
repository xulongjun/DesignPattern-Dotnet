namespace Prototype
{
    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    public abstract class Prototype()
    {
        public string? Id { get; set; }
        // Constructor
        public abstract Prototype Clone();
    }

    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>
    public class ConcretePrototype1 : Prototype
    {
        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }

    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>
    public class ConcretePrototype2 : Prototype
    {

        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}
