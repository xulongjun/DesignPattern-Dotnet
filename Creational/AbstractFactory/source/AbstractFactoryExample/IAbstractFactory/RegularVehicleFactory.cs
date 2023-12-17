﻿using AbstractFactoryExample.IAbstractProductA;
using AbstractFactoryExample.IAbstractProductB;

namespace AbstractFactoryExample.IAbstractFactory
{
    // The ConcreteFactory1 class
    // Concrete Factories produce a family of products that belong to a single variant. 
    // The following Concrete Factory Produces Regular Bike and Car which are compatible
    // The signatures of the Concrete Factory's methods return an abstract product (IBike) and (ICar) 
    // while inside the method a concrete product (new RegularBike and new RegularCar) is instantiated.
    public class RegularVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new RegularBike();
        }
        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }
}
