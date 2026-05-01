
using Flyweight;

var factory = new FlyweightFactory();

var f1 = factory.Get('A');
var f2 = factory.Get('A');
var f3 = factory.Get('B');

Console.WriteLine($"A is shared: {ReferenceEquals(f1, f2)}");
Console.WriteLine($"Factory count: {factory.Count}");

f1.Operation("x=10,y=20,color=red");
f3.Operation("x=12,y=20,color=blue");

