namespace AbstractFactory
{
    /// <summary>
    /// The 'AbstractProductA' abstract class
    /// </summary>
    internal interface IAbstractProductA
    {
    }

    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    internal class ProductA1 : IAbstractProductA
    {
        public override string ToString()
        {
            return "ProductA1";
        }
    }

    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    internal class ProductA2 : IAbstractProductA
    {
        public override string ToString()
        {
            return "ProductA2";
        }
    }
}
