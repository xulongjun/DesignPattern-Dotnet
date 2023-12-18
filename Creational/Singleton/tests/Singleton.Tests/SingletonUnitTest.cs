namespace Singleton.Tests
{
    public class SingletonUnitTest
    {
        [Fact]
        public void Singleton_Returns_Same_Instance()
        {
            // Arrange & Act
            SingletonLazy instance1 = SingletonLazy.Instance;
            SingletonLazy instance2 = SingletonLazy.Instance;

            SingletonStatic instance3 = SingletonStatic.Instance;
            SingletonStatic instance4 = SingletonStatic.Instance;

            // Assert
            Assert.Same(instance1, instance2);
            Assert.Same(instance3, instance4);
        }

        [Fact]
        public void Singleton_Returns_Valid_Data()
        {
            // Arrange
            SingletonLazy instanceLazy = SingletonLazy.Instance;
            SingletonStatic instanceStatic = SingletonStatic.Instance;

            // Act
            string dataLazy = instanceLazy.Data;
            string dataStatic = instanceStatic.Data;

            // Assert
            Assert.Equal("Singleton Data", dataLazy);
            Assert.Equal("Singleton Data", dataStatic);
        }
    }
}