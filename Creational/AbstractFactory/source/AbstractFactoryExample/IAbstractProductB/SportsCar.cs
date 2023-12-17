﻿namespace AbstractFactoryExample.IAbstractProductB
{
    // The ProductB2 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following SportsCar Product Belongs to the Car product family
    public class SportsCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching SportsCar Details..");
        }
    }
}
