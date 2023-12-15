using AbstractFactory;

IAbstractProductA ProductA1 = new ConcreteFactory1().CreateProductA();
IAbstractProductB ProductB1 = new ConcreteFactory1().CreateProductB();
Console.WriteLine(ProductA1);
Console.WriteLine(ProductB1);

IAbstractProductA ProductA2 = new ConcreteFactory2().CreateProductA();
IAbstractProductB ProductB2 = new ConcreteFactory2().CreateProductB();
Console.WriteLine(ProductA2);
Console.WriteLine(ProductB2);
