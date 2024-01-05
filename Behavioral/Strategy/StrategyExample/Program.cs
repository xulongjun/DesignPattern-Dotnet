// The client code picks a concrete strategy and passes it to the context. 
// The client should be aware of the differences between strategies in order to make the right choice.
//Create an instance of ZipCompression Strategy
using StrategyExample.Context;
using StrategyExample.Strategy;

ICompression strategy = new ZipCompression();
//Pass ZipCompression Strategy as an argument to the CompressionContext constructor
CompressionContext ctx = new(strategy);
ctx.CreateArchive("testfile");
//Changing the Strategy using SetStrategy Method
ctx.SetStrategy(new RarCompression());
ctx.CreateArchive("testfile");