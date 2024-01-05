using CommandExample.Command;
using CommandExample.Receiver;

namespace CommandExample.Tests
{
    public class CommandUnitTest
    {
        [Theory]
        [InlineData("Open", "Document Opened")]
        [InlineData("Save", "Document Saved")]
        [InlineData("Close", "Document Closed")]
        public void WhenExecuteCommand_ThenDocumentShouldBeInExpectedState(string commandType, string expectedResult)
        {
            // Arrange
            Document document = new();
            ICommand command = commandType switch
            {
                "Open" => new OpenCommand(document),
                "Save" => new SaveCommand(document),
                "Close" => new CloseCommand(document),
                _ => throw new InvalidOperationException("Invalid command type")
            };

            // Act
            command.Execute();

            // Assert
            Assert.Equal(expectedResult, document.MessageTest);
        }
    }
}
