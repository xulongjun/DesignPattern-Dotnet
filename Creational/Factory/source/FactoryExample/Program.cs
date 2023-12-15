using FactoryExample.Creator;
using FactoryExample.Product;

Console.WriteLine("Select the payment gateway (PayPal, Stripe, CreditCard): ");
string gatewayName = Console.ReadLine() ?? string.Empty;
try
{
    IPaymentGateway paymentGateway = PaymentGatewayFactory.CreatePaymentGateway(gatewayName);
    paymentGateway.ProcessPayment(100.00M);  // Example amount
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadKey();
