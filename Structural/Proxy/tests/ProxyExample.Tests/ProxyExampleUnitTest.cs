using ProxyExample.Models;
using ProxyExample.Proxy;

namespace ProxyExample.Tests
{
    public class ProxyExampleUnitTest
    {
        public class SharedFolderProxyTests
        {
            [Theory]
            [InlineData("CEO", "You have access")]
            [InlineData("Manager", "You have access")]
            [InlineData("Employee", "You don't have access")]
            public void GivenEmployeeRole_WhenPerformRWOperations_ThenCorrectMessageDisplayed(string role, string expectedMessage)
            {
                // Arrange
                var employee = new Employee("testUser", "testPass", role);
                var sharedFolderProxy = new SharedFolderProxy(employee);

                // Act
                sharedFolderProxy.PerformRWOperations();

                // Assert
                string actualMessage = sharedFolderProxy.messageTest.Contains("don't have permission") ? "You don't have access" : "You have access";
                Assert.Equal(expectedMessage, actualMessage);
            }
        }
    }
}