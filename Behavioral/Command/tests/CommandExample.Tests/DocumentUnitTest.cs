using CommandExample.Receiver;

namespace CommandExample.Tests
{
    public class DocumentUnitTest
    {
        [Theory]
        [InlineData("Open", "Document Opened")]
        [InlineData("Save", "Document Saved")]
        [InlineData("Close", "Document Closed")]
        public void WhenCommandExecuted_ThenMessageTestShouldBeExpectedResult(string commandType, string expectedResult)
        {
            // Arrange
            Document document = new();

            // Act
            switch (commandType)
            {
                case "Open":
                    document.Open();
                    break;
                case "Save":
                    document.Save();
                    break;
                case "Close":
                    document.Close();
                    break;
            }

            // Assert
            Assert.Equal(expectedResult, document.MessageTest);
        }
    }
}
