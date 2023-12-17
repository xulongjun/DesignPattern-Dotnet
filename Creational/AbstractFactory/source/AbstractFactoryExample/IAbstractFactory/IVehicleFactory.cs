using AbstractFactoryExample.IAbstractProductA;
using AbstractFactoryExample.IAbstractProductB;

namespace AbstractFactoryExample.IAbstractFactory
{
    // The AbstractFactory interface
    // The Abstract Factory interface declares a set of methods that return different abstract products. 
    // These products are called a family. 
    // A family of products may have several variants
    public interface IVehicleFactory
    {
        //Abstract Product A
        IBike CreateBike();
        //Abstract Product B
        ICar CreateCar();
    }
}
