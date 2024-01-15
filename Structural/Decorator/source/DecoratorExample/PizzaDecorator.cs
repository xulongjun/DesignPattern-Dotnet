namespace DecoratorExample
{
    //Inherited from the Base Component Interface
    public abstract class PizzaDecorator : IPizza
    {
        public string MessageTest { get; set; }
        //Create a Field to store the existing Pizza Object
        protected IPizza pizza;
        //Initializing the Field using Constructor
        //While Creating an instance of the PizzaDecorator (Instance of the Child Class that Implements PizzaDecorator abstract class)
        //We need to pass the existing pizza object which we want to decorate
        public PizzaDecorator(IPizza pizza)
        {
            //Store that existing pizza object in the pizza variable
            this.pizza = pizza;
        }
        //Providing Implementation for Pizza Interface i.e. MakePizza Method
        //Here, we are just calling the Concrete Component ManufactureCar Method using the existing pizza object
        //We are making this Method Virtual to allow the Child Concrete Decorator classes to override
        public virtual string MakePizza()
        {
            return pizza.MakePizza();
        }
    }
}
