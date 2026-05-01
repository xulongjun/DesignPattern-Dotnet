
using Flyweight;

namespace FlyweightExample.Tests;

public class FlyweightExampleUnitTest
{
    [Fact]
    public void FlyweightFactory_ShouldShareSameInstance_ForSameKey()
    {
        var factory = new FlyweightFactory();

        var a1 = factory.Get('A');
        var a2 = factory.Get('A');
        var b = factory.Get('B');

        Assert.Same(a1, a2);
        Assert.NotSame(a1, b);
        Assert.Equal(2, factory.Count);
    }
}

