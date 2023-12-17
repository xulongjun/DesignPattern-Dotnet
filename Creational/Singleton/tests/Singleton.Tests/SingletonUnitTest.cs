namespace Singleton.Tests
{
    public class SingletonUnitTest
    {
        [Fact]
        public void Singleton_Returns_Same_Instance()
        {
            // Arrange & Act
            var instance1 = SingletonLazy.Instance;
            var instance2 = SingletonLazy.Instance;

            var instance3 = SingletonStatic.Instance;
            var instance4 = SingletonStatic.Instance;

            // Assert
            Assert.Same(instance1, instance2);
            Assert.Same(instance3, instance4);
        }

        [Fact]
        public void Singleton_Returns_Valid_Data()
        {
            // Arrange
            var instanceLazy = SingletonLazy.Instance;
            var instanceStatic = SingletonStatic.Instance;

            // Act
            string dataLazy = instanceLazy.Data;
            string dataStatic = instanceStatic.Data;

            // Assert
            Assert.Equal("Singleton Data", dataLazy);
            Assert.Equal("Singleton Data", dataStatic);
        }
    }
}