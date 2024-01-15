namespace DecoratorExample.Tests;

public class DecoratorExampleUnitTest
{
    public IPizza PlainPizza { get; set; } = new PlainPizza();

    [Fact]
    public void MakePizza_WhenCalled_ReturnsPlainPizza()
    {
        // Act
        var result = PlainPizza.MakePizza();

        // Assert
        Assert.Equal("Plain Pizza", result);
    }

    [Fact]
    public void MakePizza_WithPlainPizza_ReturnsChickenPizza()
    {
        // Arrange
        var chickenPizza = new ChickenPizzaDecorator(PlainPizza);

        // Act
        var result = chickenPizza.MakePizza();

        // Assert
        Assert.Equal("Plain Pizza, Chicken added", result);
    }

    [Fact]
    public void MakePizza_WithPlainPizza_ReturnsVegPizza()
    {
        // Arrange
        var vegPizza = new VegPizzaDecorator(PlainPizza);

        // Act
        var result = vegPizza.MakePizza();

        // Assert
        Assert.Equal("Plain Pizza, Vegetables added", result);
    }
}