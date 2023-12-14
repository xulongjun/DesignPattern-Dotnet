namespace FactoryExample.Product
{
    public class StripeGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ${amount} payment using Stripe...");
            // Actual integration and logic for Stripe
        }
    }
}
