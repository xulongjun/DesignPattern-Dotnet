// See https://aka.ms/new-console-template for more information
using Prototype;

// Create two instances and clone each
ConcretePrototype1 p1 = new() { Id = "I" };
ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
Console.WriteLine("Cloned: {0}", c1.Id);
ConcretePrototype2 p2 = new() { Id = "II" };
ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
Console.WriteLine("Cloned: {0}", c2.Id);