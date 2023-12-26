namespace ObserverExample.Tests
{
    public class ObserverExampleUnitTest
    {
        private readonly Subject.Subject subject = new("Product1", 100, "Out of Stock");
        private readonly Observer.Observer observer1 = new("User1");
        private readonly Observer.Observer observer2 = new("User2");

        [Fact]
        public void WhenObserverAddSubscriber_Successful()
        {
            // Act
            observer1.AddSubscriber(subject);

            // Assert
            Assert.Contains(observer1, subject.Observers);
        }

        [Fact]
        public void WhenObserverAddRemoveSubscriber_ThenSuccessful()
        {
            observer1.AddSubscriber(subject);

            // Act
            observer1.RemoveSubscriber(subject);

            // Assert
            Assert.DoesNotContain(observer1, subject.Observers);
        }

        [Fact]
        public void WhenSubjectStateChange_ThenNotifyObservers()
        {
            // Arrange
            observer1.AddSubscriber(subject);
            observer2.AddSubscriber(subject);
            StringWriter consoleOutput = new();
            Console.SetOut(consoleOutput);

            // Act
            subject.SetAvailability("In Stock");

            // Assert
            string output = consoleOutput.ToString();
            Assert.Contains("Hello User1, Product is now In Stock on Amazon", output);
            Assert.Contains("Hello User2, Product is now In Stock on Amazon", output);
        }
    }
}