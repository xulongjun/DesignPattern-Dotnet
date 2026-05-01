using StateExample.Order;

namespace StateExample.Tests;

public class OrderTests
{
    [Fact]
    public void Order_ShouldTransition_Draft_To_Paid_To_Shipped()
    {
        var order = new Order();
        Assert.Equal("Draft", order.Status);

        order.Pay();
        Assert.Equal("Paid", order.Status);

        order.Ship();
        Assert.Equal("Shipped", order.Status);
    }
}

