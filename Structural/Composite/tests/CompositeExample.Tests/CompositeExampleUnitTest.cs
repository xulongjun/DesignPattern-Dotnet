namespace CompositeExample.Tests
{
    public class CompositeExampleUnitTest
    {
        [Theory]
        [InlineData("Leaf1", 100)]
        [InlineData("Leaf2", 200)]
        public void WhenDisplayPriceCalled_ThenDisplayMessageUpdated(string name, int price)
        {
            // Arrange
            var leaf = new Leaf(name, price);

            // Act
            leaf.DisplayPrice();

            // Assert
            Assert.Equal($"\tComponent Name: {name} and Price: {price}", leaf.DisplayMessage);
        }

        [Fact]
        public void WhenDisplayPriceCalled_ThenChildComponentsDisplayPriceInvoked()
        {
            // Arrange
            var composite = new Composite("Composite1");
            var leaf1 = new Leaf("Leaf1", 100);
            var leaf2 = new Leaf("Leaf2", 200);
            composite.AddComponent(leaf1);
            composite.AddComponent(leaf2);

            // Act
            composite.DisplayPrice();

            // Assert
            Assert.Contains(leaf1, composite.components);
            Assert.Contains(leaf2, composite.components);
        }
    }
}