
using Flyweight;

var factory = new FlyweightFactory();

foreach (var c in "HELLO")
{
    var flyweight = factory.Get(c);
    flyweight.Operation($"pos={Array.IndexOf("HELLO".ToCharArray(), c)}");
}

Console.WriteLine($"Flyweights created: {factory.Count}");

