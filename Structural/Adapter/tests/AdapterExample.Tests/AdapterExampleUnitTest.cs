using AdapterExample.Adapter;

namespace AdapterExample.Tests
{
    public class AdapterExampleUnitTest
    {
        [Fact]
        public void TestEmployeeAdapter_ProcessCompanySalary()
        {
            // Arrange
            var adapter = new EmployeeAdapter();
            string[,] employeesArray = new string[,]
            {
                { "1", "John Doe", "Developer", "70000" },
                { "2", "Jane Smith", "Manager", "90000" }
            };

            var originalConsoleOut = Console.Out; // Save the original console output stream
            using var sw = new StringWriter();
            Console.SetOut(sw); // Redirect console output to StringWriter

            // Act
            adapter.ProcessCompanySalary(employeesArray);

            // Reset the console output to original
            Console.SetOut(originalConsoleOut);
            var result = sw.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            // Assert
            // Verify that the output contains expected lines
            Assert.Contains(result, line => line.Contains("Rs.70000 Salary Credited to John Doe Account"));
            Assert.Contains(result, line => line.Contains("Rs.90000 Salary Credited to Jane Smith Account"));

            // Verify console output for Adapter
            Assert.Contains(result, line => line.Contains("Adapter converted Array of Employee to List of Employee"));
        }
    }
}