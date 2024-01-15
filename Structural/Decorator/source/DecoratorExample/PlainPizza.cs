namespace DecoratorExample
{
    // Concrete Components provide default implementations of the operations.
    public class PlainPizza : IPizza
    {
        public string MessageTest { get; set; }
        //The following MakePizza method returns the default Pizza
        public string MakePizza()
        {
            MessageTest = "Plain Pizza";
            return MessageTest;
        }
    }
}
