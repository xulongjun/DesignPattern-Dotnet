namespace DecoratorExample.Tests;

public class DecoratorExampleUnitTest
{
    public IPizza PlainPizza { get; set; } = new PlainPizza();

    [Fact]
    public void MakePizza_WhenCalled_ReturnsPlainPizza()
    {
        // Act
        string result = PlainPizza.MakePizza();

        // Assert
        Assert.Equal("Plain Pizza", result);
    }

    [Fact]
    public void MakePizza_WithPlainPizza_ReturnsChickenPizza()
    {
        // Arrange
        ChickenPizzaDecorator chickenPizza = new(PlainPizza);

        // Act
        string result = chickenPizza.MakePizza();

        // Assert
        Assert.Equal("Plain Pizza, Chicken added", result);
    }

    [Fact]
    public void MakePizza_WithPlainPizza_ReturnsVegPizza()
    {
        // Arrange
        VegPizzaDecorator vegPizza = new(PlainPizza);

        // Act
        string result = vegPizza.MakePizza();

        // Assert
        Assert.Equal("Plain Pizza, Vegetables added", result);
    }
}