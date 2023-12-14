namespace FactoryExample.Product
{
    //Concrete Implementations for the Products
    public class PayPalGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ${amount} payment using PayPal...");
            // Actual integration and logic for PayPal
        }
    }
}
