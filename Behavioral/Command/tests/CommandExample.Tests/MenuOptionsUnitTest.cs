using CommandExample.Command;
using CommandExample.Invoker;
using CommandExample.Receiver;

namespace CommandExample.Tests
{
    public class MenuOptionsUnitTest
    {
        private readonly Document _document;
        private readonly MenuOptions _menuOptions;
        private readonly ICommand _openCommand;
        private readonly ICommand _saveCommand;
        private readonly ICommand _closeCommand;

        public MenuOptionsUnitTest()
        {
            _document = new Document();
            _openCommand = new OpenCommand(_document);
            _saveCommand = new SaveCommand(_document);
            _closeCommand = new CloseCommand(_document);
            _menuOptions = new MenuOptions(_openCommand, _saveCommand, _closeCommand);
        }

        [Theory]
        [InlineData("Open", "Document Opened")]
        [InlineData("Save", "Document Saved")]
        [InlineData("Close", "Document Closed")]
        public void WhenMenuOptionClicked_ThenDocumentShouldBeInExpectedState(string menuOption, string expectedResult)
        {
            // Act
            switch (menuOption)
            {
                case "Open":
                    _menuOptions.ClickOpen();
                    break;
                case "Save":
                    _menuOptions.ClickSave();
                    break;
                case "Close":
                    _menuOptions.ClickClose();
                    break;
                default:
                    throw new ArgumentException("Invalid menu option");
            }

            // Assert
            Assert.Equal(expectedResult, _document.MessageTest);
        }
    }
}