namespace AbstractFactory
{
    /// <summary>
    /// The 'AbstractProductA' abstract class
    /// </summary>
    internal interface IAbstractProductB
    {
    }

    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    internal class ProductB1 : IAbstractProductB
    {
        public override string ToString()
        {
            return "ProductB1";
        }
    }

    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    internal class ProductB2 : IAbstractProductB
    {
        public override string ToString()
        {
            return "ProductB2";
        }
    }
}
