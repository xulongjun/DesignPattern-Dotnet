using Moq;

namespace BridgeExample.Tests;

public class BridgeExampleUnitTests
{
    private readonly Mock<IMessageSender> _mockMessageSender;

    private readonly Mock<IMessageSender> _mockSmsMessageSender;
    private readonly Mock<IMessageSender> _mockEmailMessageSender;
    private string _messageSentBySms;
    private string _messageSentByEmail;

    public BridgeExampleUnitTests()
    {
        _mockMessageSender = new Mock<IMessageSender>();

        _mockSmsMessageSender = new Mock<IMessageSender>();
        _mockEmailMessageSender = new Mock<IMessageSender>();

        // Setup mock behavior for SMS
        _ = _mockSmsMessageSender.Setup(m => m.SendMessage(It.IsAny<string>()))
            .Callback<string>(message => _messageSentBySms = message);

        // Setup mock behavior for Email
        _ = _mockEmailMessageSender.Setup(m => m.SendMessage(It.IsAny<string>()))
            .Callback<string>(message => _messageSentByEmail = message);
    }

    [Theory]
    [InlineData("Hello", "Hello")]
    [InlineData("Hi", "Hi")]
    public void GivenShortMessage_WhenMessageIsShort_ThenItIsSent(string input, string expected)
    {
        ShortMessage shortMessage = new(_mockMessageSender.Object);
        shortMessage.SendMessage(input);
        _mockMessageSender.Verify(m => m.SendMessage(It.Is<string>(s => s == expected)), Times.Once);
    }

    [Theory]
    [InlineData("This is a long message")]
    [InlineData("12345678901")] // 11 characters
    public void GivenShortMessage_WhenMessageIsLong_ThenErrorMessageIsSet(string input)
    {
        ShortMessage shortMessage = new(_mockMessageSender.Object);
        shortMessage.SendMessage(input);
        Assert.Equal("Unable to send the message as length > 10 characters", shortMessage.MessageTest);
    }

    [Theory]
    [InlineData("A long message here")]
    [InlineData("Short")]
    public void GivenLongMessage_WhenAnyMessage_ThenItIsSent(string input)
    {
        LongMessage longMessage = new(_mockMessageSender.Object);
        longMessage.SendMessage(input);
        _mockMessageSender.Verify(m => m.SendMessage(It.Is<string>(s => s == input)), Times.Once);
    }

    [Theory]
    [InlineData("Short SMS")]
    public void GivenShortMessage_WhenSentBySms_ThenSmsIsSent(string message)
    {
        ShortMessage shortMessage = new(_mockSmsMessageSender.Object);
        shortMessage.SendMessage(message);
        Assert.Equal(message, _messageSentBySms);
        Assert.Null(_messageSentByEmail); // Ensure it wasn't sent by email
    }

    [Theory]
    [InlineData("ShortEmail")]
    public void GivenShortMessage_WhenSentByEmail_ThenEmailIsSent(string message)
    {
        ShortMessage shortMessage = new(_mockEmailMessageSender.Object);
        shortMessage.SendMessage(message);
        Assert.Equal(message, _messageSentByEmail);
        Assert.Null(_messageSentBySms); // Ensure it wasn't sent by SMS
    }

    [Theory]
    [InlineData("Long SMS Message")]
    public void GivenLongMessage_WhenSentBySms_ThenSmsIsSent(string message)
    {
        LongMessage longMessage = new(_mockSmsMessageSender.Object);
        longMessage.SendMessage(message);
        Assert.Equal(message, _messageSentBySms);
        Assert.Null(_messageSentByEmail); // Ensure it wasn't sent by email
    }

    [Theory]
    [InlineData("Long Email Message")]
    public void GivenLongMessage_WhenSentByEmail_ThenEmailIsSent(string message)
    {
        LongMessage longMessage = new(_mockEmailMessageSender.Object);
        longMessage.SendMessage(message);
        Assert.Equal(message, _messageSentByEmail);
        Assert.Null(_messageSentBySms); // Ensure it wasn't sent by SMS
    }
}