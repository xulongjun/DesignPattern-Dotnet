using FactoryExample.Product;

namespace FactoryExample.Creator
{
    //Factory Class to Produce the Products
    public static class PaymentGatewayFactory
    {
        public static IPaymentGateway CreatePaymentGateway(string gatewayName)
        {
            return gatewayName switch
            {
                "PayPal" => new PayPalGateway(),
                "Stripe" => new StripeGateway(),
                "Credit Card" => new CreditCardGateway(),
                _ => throw new ArgumentException($"Invalid payment gateway specified : {gatewayName}"),
            };
        }
    }
}
