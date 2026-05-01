using VisitorExample.Shapes;

namespace VisitorExample.Tests;

public class AreaVisitorTests
{
    [Fact]
    public void AreaVisitor_ShouldComputeAreas()
    {
        var visitor = new AreaVisitor();

        var circle = new Circle(1);
        var rect = new Rectangle(2, 3);

        Assert.Equal(Math.PI, circle.Accept(visitor), 5);
        Assert.Equal(6, rect.Accept(visitor), 5);
    }
}

