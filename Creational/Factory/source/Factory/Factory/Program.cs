using Factory;

// An array of creators
Creator[] creators = [new ConcreteCreatorA(), new ConcreteCreatorB()];

// Iterate over creators and create products
foreach (Creator creator in creators)
{
    IProduct product = creator.FactoryMethod();
    Console.WriteLine("Created {0}",
      product.GetType().Name);
}
// Wait for user
Console.ReadKey();