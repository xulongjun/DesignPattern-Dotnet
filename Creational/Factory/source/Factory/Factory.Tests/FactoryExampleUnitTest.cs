using FactoryExample.Creator;
using FactoryExample.Product;

namespace Factory.Tests
{
    public class FactoryExampleUnitTest
    {
        private IPaymentGateway? PaymentGateway;

        [Theory]
        [InlineData("PayPal")]
        [InlineData("Stripe")]
        [InlineData("Credit Card")]
        public void WhenTestingExistingPaymentGateway_ThenShowPaymentGatewayProcess(string gatewayName)
        {
            // Arrange
            string expectedMessage = $"Processing ${100.00M} payment using {gatewayName}...";
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            PaymentGateway = PaymentGatewayFactory.CreatePaymentGateway(gatewayName);
            PaymentGateway.ProcessPayment(100.00M);

            // Assert
            string resultMessage = sw.ToString().Trim();
            Assert.Equal(expectedMessage, resultMessage);
        }

        [Theory]
        [InlineData("test")]
        public void WhenTestingUnExistingPaymentGateway_ThenThrowException(string gatewayName)
        {
            // Arrange
            string expectedMessage = $"Invalid payment gateway specified : {gatewayName}";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                PaymentGateway = PaymentGatewayFactory.CreatePaymentGateway(gatewayName);
                PaymentGateway.ProcessPayment(100.00M);
            });

            // Assert that the exception message is as expected
            Assert.Equal(expectedMessage, exception.Message);
        }
    }
}