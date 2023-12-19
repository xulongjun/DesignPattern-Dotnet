using FacadeExample.Facade;
using FacadeExample.Models;

namespace FacadeExample.Tests
{
    public class FacadeExampleUnitTest
    {
        [Fact]
        public void RegisterCustomer_ShouldCompleteWithoutExceptions()
        {
            // Arrange
            CustomerRegistration registration = new();
            Customer customer = new()
            {
                Name = "John Doe",
                Email = "john.doe@example.com",
                MobileNumber = "1234567890",
                Address = "123 Main St"
            };

            TextWriter originalConsoleOut = Console.Out; // Save the original console output stream
            using StringWriter sw = new();
            Console.SetOut(sw); // Redirect console output to StringWriter

            // Act
            bool result = registration.RegisterCustomer(customer);

            // Reset the console output to original
            Console.SetOut(originalConsoleOut);
            string consoleOutput = sw.ToString();

            // Assert
            Assert.True(result);
            Assert.Contains("Customer Validated", consoleOutput);
            Assert.Contains("Customer Saved into the Database", consoleOutput);
            Assert.Contains("Registration Email Send to Customer", consoleOutput);
        }
    }
}